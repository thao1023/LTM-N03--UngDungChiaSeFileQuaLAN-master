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

namespace Server
{
    public partial class Form1 : Form
    {
        public int s;
        private TcpListener listener;
        private Thread listenerThread;
        private delegate void SafeCallDelegate(string text);
        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private string filePath;
        private int fileSize;
        private int totalReceived;
        private List<byte[]> receivedFilesData;
        private List<string> receivedFileNames;
        private string username;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50; // Cập nhật mỗi giây
            timer1.Tick += new EventHandler(timer1_Tick);
            receivedFilesData = new List<byte[]>();
            receivedFileNames = new List<string>();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.AppendText("Starting the server...\r\n");
            listener = new TcpListener(IPAddress.Parse(txtHost.Text), int.Parse(txtPort.Text));
            listener.Start();
            txtStatus.AppendText("OK! Địa chỉ IP là: " + txtHost.Text + " cổng: " + txtPort.Text + "\r\n");

            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        Task.Run(() => HandleClient(client));
                    }
                    catch (Exception ex)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            txtStatus.AppendText("Lỗi: " + ex.Message + "\r\n");
                        });
                        break;
                    }
                }
            });
        }

        private void HandleClient(TcpClient client)
        {
            try
            {
                using (NetworkStream stream = client.GetStream())
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    string username = reader.ReadString(); // Đọc tên đăng nhập từ client
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtStatus.AppendText($"Đã có kết nối tới từ {username}\r\n");
                    });

                    int numberOfFiles = reader.ReadInt32();
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtStatus.AppendText($"Số lượng file cần nhận: {numberOfFiles} từ {username}\r\n");
                    });

                    for (int i = 0; i < numberOfFiles; i++)
                    {
                        int fileSize = reader.ReadInt32();
                        string fileName = reader.ReadString();
                        this.Invoke((MethodInvoker)delegate
                        {
                            txtStatus.AppendText($"Đang nhận: {fileName} từ {username}\r\n");
                        });

                        byte[] fileData = new byte[fileSize];
                        int totalReceived = 0;
                        while (totalReceived < fileSize)
                        {
                            int received = stream.Read(fileData, totalReceived, fileSize - totalReceived);
                            totalReceived += received;
                        }

                        receivedFilesData.Add(fileData);
                        receivedFileNames.Add(fileName);

                        this.Invoke((MethodInvoker)delegate
                        {
                            txtStatus.AppendText($"Đã nhận: {fileName} từ {username}\r\n");
                        });
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        txtStatus.AppendText("Tất cả các file đã được nhận\r\n");
                    });
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtStatus.AppendText("Lỗi: " + ex.Message + "\r\n");
                });
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFolderPath = folderBrowserDialog.SelectedPath;

                // Lưu các file vào thư mục đã chọn
                for (int i = 0; i < receivedFilesData.Count; i++)
                {
                    string saveFilePath = Path.Combine(saveFolderPath, receivedFileNames[i]);
                    File.WriteAllBytes(saveFilePath, receivedFilesData[i]);
                }

                txtDuongDan.Text = saveFolderPath;

                // Khởi động timer
                timer1.Start();

                // Đặt lại giá trị của progressBar1 và s
                progressBar1.Value = 0;
                s = 0;
            }
        }

        private byte[] receivedData; // Khai báo một biến để lưu dữ liệu nhận được
        private void ReceiveFile()
        {
            try
            {
                int numberOfFiles = reader.ReadInt32();
                this.Invoke((MethodInvoker)delegate
                {
                    txtStatus.AppendText($"Số lượng file cần nhận: {numberOfFiles} từ {username}\r\n");
                });

                for (int i = 0; i < numberOfFiles; i++)
                {
                    int fileSize = reader.ReadInt32();
                    string fileName = reader.ReadString();
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtStatus.AppendText($"Đang nhận: {fileName} từ {username}\r\n");
                    });

                    byte[] fileData = new byte[fileSize];
                    int totalReceived = 0;
                    while (totalReceived < fileSize)
                    {
                        int received = stream.Read(fileData, totalReceived, fileSize - totalReceived);
                        totalReceived += received;
                    }

                    receivedFilesData.Add(fileData);
                    receivedFileNames.Add(fileName);

                    this.Invoke((MethodInvoker)delegate
                    {
                        txtStatus.AppendText($"Đã nhận: {fileName} từ {username}\r\n");
                    });
                }

                this.Invoke((MethodInvoker)delegate
                {
                    txtStatus.AppendText("Tất cả các file đã được nhận\r\n");
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtStatus.AppendText("Lỗi: " + ex.Message + "\r\n");
                });
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtStatus.AppendText("Stopping the server...\r\n");
            listener.Stop();
            txtStatus.AppendText("The server has been stopped !!!\r\n");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value + 1 <= progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                s++;
                label4.Text = s + "%";
                if (progressBar1.Value == 100)
                {
                    timer1.Stop();
                    string successMessage;
                    if (receivedFilesData.Count == 1)
                    {
                        successMessage = "Đã lưu file thành công!";
                    }
                    else
                    {
                        successMessage = "Đã lưu tất cả các file thành công!";
                    }
                    txtStatus.AppendText(successMessage + "\r\n");
                    MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset lại dữ liệu sau khi lưu
                    receivedFilesData.Clear();
                    receivedFileNames.Clear();
                }
            }
        }
    }
}
