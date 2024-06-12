using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AES_encoder_decoder
{
    public partial class AES : Form
    {
        public AES()
        {
            InitializeComponent();
        }

        private void comboBoxKey_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Key.Clear();
            
            byte[] randomized_keys = new byte[16];
            rnd.NextBytes(randomized_keys);
            Debug.WriteLine("int representation of key: ");
            foreach(byte i in randomized_keys)
            {
                Debug.Write((int)i);
                Debug.Write(",");
            }
            string base64_randomized_keys = Convert.ToBase64String(randomized_keys);
            Key.Text = base64_randomized_keys;
        }
        byte[] input_byte_buffer;
        byte[] output_byte_buffer;
       
        bool is_file_opened = false;
        bool is_txt_file_opened = false;
        bool last_action_is_encryption = false;
        private byte[] Get_textbox_input_byte_representation(string textbox_message)
        {
            Encoding unicodeEncoder = new UTF8Encoding();
            
            return unicodeEncoder.GetBytes(textbox_message);
        }
        private string Get_textbox_base64_representation_of_byte_buffer(byte[] byte_buffer)
        {
            if (byte_buffer.Length > 16000)
            {
                string textbox_output_buffer_representation = Convert.ToBase64String(byte_buffer, 0, 16000);
                return textbox_output_buffer_representation;
                

            }
            else
            {
                string textbox_output_buffer_representation = Convert.ToBase64String(byte_buffer);
                return textbox_output_buffer_representation;
            }
        }
        private string Get_textbox_unicode_representation_of_byte_buffer(byte[] byte_buffer)
        {
            Encoding unicodeEncoder = new UTF8Encoding();
            string unicode_representation = unicodeEncoder.GetString(byte_buffer);
            if (unicode_representation.Length > 30000)
            {
                unicode_representation = unicode_representation.Substring(0, 30000);
            }
            return unicode_representation;
        }
        private void FromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "All files (*.*)|*.*"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine("FileName: " + openFile.FileName);
                Debug.WriteLine("Extensions is: " + Path.GetExtension(openFile.FileName));

                string file_extension = Path.GetExtension(openFile.FileName);
                is_file_opened = true;
                input_byte_buffer = File.ReadAllBytes(openFile.FileName);

                if (file_extension == ".enc")
                {
                    string encrypted_file_true_name = Path.GetFileNameWithoutExtension(openFile.FileName);
                    string encrypted_file_true_extension = Path.GetExtension(encrypted_file_true_name);
                    if (encrypted_file_true_extension == ".txt")
                    {
                        
                        is_txt_file_opened = true;
                    }
                }

                
                if (file_extension == ".txt")
                {
                    textBox1.Text = Get_textbox_unicode_representation_of_byte_buffer(input_byte_buffer);
                    is_txt_file_opened = true;
                }
                
                else
                {
                    textBox1.Text = Get_textbox_base64_representation_of_byte_buffer(input_byte_buffer);
                }
                last_opened_textbox.Text = openFile.FileName;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            KeySize.SelectedItem = "128";
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "Txt Files|*.txt"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader fileTxt = new StreamReader(openFile.FileName, Encoding.Default);
                Key.Clear();
                Key.Text = Convert.ToString(fileTxt.ReadToEnd());
                fileTxt.Close();
            }
        }

        private void Cleaner_Click(object sender, EventArgs e)
        {
            Key.Clear();
            textBox1.Clear();
            textBox2.Clear();
            is_file_opened = false;
            is_txt_file_opened = false;
            last_saved_textbox.Clear();
            last_opened_textbox.Clear();
        }

        private void SaveText_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string final_save_filename;
                if (last_action_is_encryption)
                {
                    string last_opened_file_path = last_opened_textbox.Text;
                    string last_opened_filename = Path.GetFileName(last_opened_file_path);
                    final_save_filename = last_opened_filename + ".enc";
                }
                else
                {
                    final_save_filename = Path.GetFileNameWithoutExtension(last_opened_textbox.Text);
                }
                
                SaveFileDialog saveFile = new SaveFileDialog()
                {
                    Filter = "All files (*.*)|*.*",
                    FileName = final_save_filename,
                    
                };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    
                    File.WriteAllBytes(saveFile.FileName, output_byte_buffer);

                    last_saved_textbox.Text = saveFile.FileName;
                    
                }
            }
            else MessageBox.Show("Encrytpt or decrypt your text.", "Error!");
        }
        private byte[] Get_key_bytes_representaion(string key_text)
        {

            // https://learn.microsoft.com/en-us/dotnet/api/system.span-1?view=net-7.0
            // https://learn.microsoft.com/en-us/dotnet/api/system.convert.tryfrombase64string?view=net-7.0
            Span<byte> returned_bytes = new Span<byte>(new byte[16]);
            if (Convert.TryFromBase64String(key_text, returned_bytes, out int bytesParsed))
            {
                return returned_bytes.ToArray();
            }
            else
            {
                Encoding unicodeEncoder = new UTF8Encoding();
                
                Byte[] byte_representation_of_string = unicodeEncoder.GetBytes(key_text);

                Byte[] resulting_key = new Byte[16];

                if (byte_representation_of_string.Length > 16)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        resulting_key[i] = byte_representation_of_string[i];
                    }
                }
                else
                {
                    for (int i = 0; i < byte_representation_of_string.Length; i++)
                    {
                        resulting_key[i] = byte_representation_of_string[i];
                    }
                }

                return resulting_key;
            }
            
           
            
            
        }
        private void Encrypter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                    
                    if (Key.Text != "")
                    {
                        byte[] bytes_key_representation = Get_key_bytes_representaion(Key.Text);
                    Debug.WriteLine("Key length is: {0}", bytes_key_representation.Length);
                    Debug.WriteLine("int representation of key: ");
                    foreach (byte i in bytes_key_representation)
                    {
                        Debug.Write((int)i);
                        Debug.Write(",");
                    }
                    Debug.WriteLine("");
                    if (bytes_key_representation.Length == 16)
                    {
                        textBox2.Clear();
                        if (is_file_opened == false)
                        {
                            input_byte_buffer = Get_textbox_input_byte_representation(textBox1.Text);
                            
                        }
                        AES aes = new AES(bytes_key_representation, input_byte_buffer);
                        output_byte_buffer = aes.AESEncrypt();

                        textBox2.Text = Get_textbox_base64_representation_of_byte_buffer(output_byte_buffer);
                        last_action_is_encryption = true;
                    }
                    else MessageBox.Show("Key is not 16 bytes", "ERROR!");
                    }
                    else MessageBox.Show("Add key.", "Error!");
                
            }
            else MessageBox.Show("Add text.", "Error!");
        }

        private void Decrypter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {


                if (Key.Text != "")
                {
                    byte[] bytes_key_representation = Get_key_bytes_representaion(Key.Text);
                    if (bytes_key_representation.Length == 16) { 
                        textBox2.Clear();

                        if (is_file_opened == false && last_action_is_encryption == false)
                        {
                            input_byte_buffer = Get_textbox_input_byte_representation(textBox1.Text);
                        }
                        Debug.WriteLine("input_byte_buffer length on decrypt stage is: {0}", input_byte_buffer.Length);
                        AES aes = new AES(bytes_key_representation, input_byte_buffer);
                        output_byte_buffer = aes.AESDecrypt();
                        last_action_is_encryption = false;
                        
                        if (is_file_opened==true && is_txt_file_opened==false)
                        {
                            textBox2.Text = Get_textbox_base64_representation_of_byte_buffer(output_byte_buffer);
                        }
                        else
                        {

                            textBox2.Text = Get_textbox_unicode_representation_of_byte_buffer(output_byte_buffer);
                        }
                        
                        
                        
                    }
                    else MessageBox.Show("Key is not 16 bytes", "ERROR!");
                }
                else MessageBox.Show("Add key.", "Error!");
                
            }
            else MessageBox.Show("Add text.", "Error!");
        }

        private void Swap_Click(object sender, EventArgs e)
        {
            
            input_byte_buffer = output_byte_buffer;
            
            textBox1.Clear();
            

            textBox1.Text = textBox2.Text;
            textBox2.Clear();

        }

        private void AES_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Key_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
