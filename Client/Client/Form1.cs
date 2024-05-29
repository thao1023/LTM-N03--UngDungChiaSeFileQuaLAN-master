using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private string filePath;
        private string username;
        public Form1(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Text = $"Welcome {username}";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient(txtHost.Text, int.Parse(txtPort.Text));
            stream = client.GetStream();
            writer = new BinaryWriter(stream);
            writer.Write(username); // Gửi tên đăng nhập tới server
            MessageBox.Show("Tên đăng nhập: " + username);
            txtLog.AppendText("Kết nối thành công tới Server !!!\r\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; // Cho phép chọn nhiều file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;
                txtLog.AppendText("Số lượng file gửi: " + fileNames.Length + "\r\n");

                writer.Write(fileNames.Length); // Gửi số lượng file

                foreach (string filePath in fileNames)
                {
                    txtLog.AppendText("Đang gửi: " + Path.GetFileName(filePath) + "\r\n");

                    byte[] fileData = File.ReadAllBytes(filePath);
                    writer.Write(fileData.Length); // Gửi kích thước file
                    writer.Write(Path.GetFileName(filePath)); // Gửi tên file
                    writer.Write(fileData); // Gửi nội dung file
                }

                string successMessage;
                if (fileNames.Length == 1)
                {
                    successMessage = "Đã gửi file thành công.";
                }
                else
                {
                    successMessage = "Đã gửi tất cả các file thành công.";
                }

                txtLog.AppendText(successMessage + "\r\n");
                MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Close();
            txtLog.AppendText("Đã ngắt kết nối tới Server !!!\r\n");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

