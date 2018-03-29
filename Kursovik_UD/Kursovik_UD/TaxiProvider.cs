using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace Kursovik_UD
{
    class TaxiProvider
    {
        //static int User_ID;
        static string username;

        public static String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaxiIS\";
        public static String fname = "preferences.xml";

        public TaxiProvider()
        {

        }

        public static bool IsExistPrefs()
        {
            if (File.Exists(path + @"preferences.xml"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ReadConfig()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("preferences.xml");
            foreach (XmlElement element in xml.GetElementsByTagName("CreateRequest"))
            {
                foreach (XmlElement e in element)
                {
                    if (e.Name == "Город")
                        username = e.InnerText;
                    if (e.Name == "Тариф")
                        username = e.InnerText;
                    if (e.Name == "Пассажиры")
                        username = e.InnerText;
                }
            }
        }

        public static void WriteConfig()            //Запись 
        {

            XmlTextWriter textWriter = new XmlTextWriter(path + fname, Encoding.UTF8);      //Перезапись
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("head");
            textWriter.WriteEndElement();
            textWriter.Close();

            XmlDocument document = new XmlDocument();
            document.Load(path + fname);

            /////CreateRequest
            XmlNode node = document.CreateElement("CreateRequest");
            document.DocumentElement.AppendChild(node);
            /*
            XmlAttribute attribute = document.CreateAttribute("number");
            attribute.Value = (counter).ToString();
            node.Attributes.Append(attribute);
            */
            XmlNode subelement1 = document.CreateElement("Город");
            subelement1.InnerText = "1";        //id мурома
            node.AppendChild(subelement1);
            XmlNode subelement2 = document.CreateElement("Тариф");
            subelement2.InnerText = "1";
            node.AppendChild(subelement2);
            XmlNode subelement3 = document.CreateElement("Пассажиры");
            subelement3.InnerText = "2";
            node.AppendChild(subelement3);
            /////

            document.Save(path + fname);
        }

        public void GetDrivers()
        {
            //lb3 show
            //select * from employee where f1 =  current_user
            /*
            string sqlCommand = "SELECT * FROM STATUS_EMPLOYEE";
            FbCommand selectCommand = new FbCommand(sqlCommand, connection);
            try
            {
                FbDataReader dataReader = selectCommand.ExecuteReader();
                /*Выборка данных из БД через FbDataReader

                if (dataReader.HasRows)
                {
                    richTextBox1.Text += "Имя \t\t\t|Поряд. номер\r\n";
                    while (dataReader.Read())
                    {
                        richTextBox1.Text += dataReader.GetString(0) + " \t| " + dataReader.GetString(2) + "\r\n";
                    }
                }
                else
                {
                    richTextBox1.Text = "No records found.";
                }
                dataReader.Close();
                dataReader.Dispose();
                selectCommand.Dispose();
            }
            catch (FbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            connection.Dispose();
            */
        }
    }
}

/*

 * String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaxiIS\";
            if (Directory.Exists(path))
            {
                if (TaxiProvider.IsExistPrefs())
                {

                }
                else
                {
                    TaxiProvider.WriteConfig();
                }
            }
            else
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaxiIS\");
                //create xml
                File.Create(path + @"preferences.xml");
            }

*/