using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.ComponentModel;
using System.IO;
using CodeLibrary;



namespace ArchivatorLibrary
{
    public class Crypt
    {
       
        //protected void InProgress(int progres)
        //{
        //    if (Progress != null)
        //        Progress(this, new);
        //}

        public string Filepath { private set; get; }
        public string Password { private set; get; }


        public Crypt(string path,string pass)
        {
            Filepath = path;
            Password = pass;
        }

        public event EventHandler<EventHandlerProgres> Progress;

        protected void InProgress(int progres)
        {
            if (Progress != null)
                Progress(this, new EventHandlerProgres(progres));
        }


        public void CryptFile()
        {
            
          
            FileStream flstrIN = File.OpenRead(Filepath);
            FileStream flstrOUT = File.OpenWrite(Filepath + ".coded");
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (o, e) =>
            {
                int symbol;
                int counter = 1;
                int PasPosition = 0;
                while ((symbol = flstrIN.ReadByte()) != -1)
                {
                    symbol = symbol ^ Password[PasPosition];
                    PasPosition++;
                    flstrOUT.WriteByte((byte)symbol);
                    if (PasPosition >= Password.Length) PasPosition = 0;

                    int percent = (int)((counter * 1.0) / flstrIN.Length * 100);
                    
                    InProgress(percent);
                     counter++;
                }
            };
            flstrIN.Close();
                flstrOUT.Close();
            
        }

        public void DecriptFile()
        {
           
                FileStream flstrIN = File.OpenRead(Filepath);
                Filepath = Filepath.Remove(Filepath.Length - 6);
                FileStream flstrOUT = File.OpenWrite(Filepath + ".decoded");
                int symbol;
                int counter = 1;
                int PasPosition = 0;
                while ((symbol = flstrIN.ReadByte()) != -1)
                {
                    symbol = symbol ^ Password[PasPosition];
                    PasPosition++;
                    flstrOUT.WriteByte((byte)symbol);
                    if (PasPosition >= Password.Length) PasPosition = 0;

                    int percent = (int)((counter * 1.0) / flstrIN.Length * 100);
                    //InProgress(percent);
                    counter++;
            }

                flstrIN.Close();
                flstrOUT.Close();
            
        }
    }
}
