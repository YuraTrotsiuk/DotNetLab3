using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.ComponentModel;
using System.IO;
using CodeLibrary;
using System.Diagnostics;



namespace ArchivatorLibrary
{
    public class Crypt
    {

        public string Filepath { private set; get; }
        public string Password { private set; get; }
        public Crypt(string path,string pass)
        {
            
            Filepath = path;
            Password = pass;
        }

        public Crypt()
        { 
        }

        public float FileSize()
        {
            FileInfo file = new FileInfo(Filepath);
            return file.Length;
        }

        public event EventHandler<EventHandlerProgres> Progress;
        protected void InProgress(int percent)
        {
            if (Progress != null)
                Progress(this, new EventHandlerProgres(percent));
        }

        public event EventHandler<EventHandlerCodeTime> Timer;
        protected void InTime(int strHour, int strMin, int strSec, int milisec)
        {
            if (Timer != null)
                Timer(this, new EventHandlerCodeTime(strHour, strMin, strSec, milisec));
        }


        public void CryptFile()
        {
            Stopwatch watch = new Stopwatch();
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (o, e) =>
                {
                    using (FileStream flstrIN = File.OpenRead(Filepath))
                    using (FileStream flstrOUT = File.OpenWrite(Filepath + ".coded"))
                    {
                        watch.Start();
                        int symbol;
                        int counter = 1;
                        int PasPosition = 0;
                        while ((symbol = flstrIN.ReadByte()) != -1)
                        {
                            symbol = symbol ^ Password[PasPosition];
                            PasPosition++;
                            flstrOUT.WriteByte((byte)symbol);
                            if (PasPosition >= Password.Length) PasPosition = 0;

                            InProgress((int)((counter * 1.0) / flstrIN.Length * 100));
                            counter++;
                        }
                    
                    }
                    watch.Stop();
                    InTime(watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);

                };
            worker.RunWorkerAsync();
        }

        public void DecriptFile()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (o, e) =>
            {
                using (FileStream flstrIN = File.OpenRead(Filepath))
                {
                    Filepath = Filepath.Remove(Filepath.Length - 6);
                    using (FileStream flstrOUT = File.OpenWrite(Filepath + ".decoded"))
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

                            InProgress((int)((counter * 1.0) / flstrIN.Length * 100));
                            counter++;
                        }
                    }
                }
            };
            worker.RunWorkerAsync();

            //flstrIN.Close();
            //flstrOUT.Close();
        }
    }
}
