using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace AutoKeyPress
{
    class SendKeyMethod
    {
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        public void StartAutoPress()
        {
            int timer = int.Parse(Constants.kTImes);


            try
            {
                String[] AllKeys = GetKeys(Constants.kKeys);


                while (timer > 0)
                {
                    Process[] processes = GetMyProcess();
                    Console.WriteLine("Number of processes running: " + processes.Length);
                    Console.WriteLine("Number of Keys: " + AllKeys.Length);

                    if (processes.Length > 0)
                    {
                        Console.WriteLine(DateTime.Now + " Running...");

                        foreach (Process proc in processes)
                        {
                            //Console.WriteLine("User is " + proc.StartInfo.UserName);
                            SetForegroundWindow(proc.MainWindowHandle);

                            foreach (String key in AllKeys)
                            {
                                SendKeys.SendWait(key);
                                Thread.Sleep(int.Parse(Constants.kSleepTIme) * 1000);
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: No processes found. ");
                    }
                    timer--;
                }
            }
            catch (TypeInitializationException ex)
            {
                Console.WriteLine("ERROR: Configuration file issue. ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }



        }

        public string[] GetKeys(String MyKeys)
        {
            String[] KeysList = MyKeys.Split('|');
            return KeysList;
        }

        public Process[] GetMyProcess()
        {

            Process[] myProcess = Process.GetProcessesByName(Constants.kProcess);
            return myProcess;
            
        }

    }
}
