using System;
using System.IO;

namespace Ex1
{
    class FarManager
    { //global variables
        public int cursor;  
        public string path; 
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;  
        FileSystemInfo currentFs = null;

        public FarManager()
        {
            cursor = 0; //first we initialize cursor as 0
        }

        public FarManager(string path)
        {
            this.path = path; //to set value of path
            cursor = 0; //our cursor is in the beginning of the list of directories
            directory = new DirectoryInfo(path); //get path of current directory
            sz = directory.GetFileSystemInfos().Length; //sz is equal to quantity of directories
            ok = true; 
        }

        public void Color(FileSystemInfo fs, int index) 
        {
            if (cursor == index) //condition to color the chosen directory whereas cursor is equal to numeration index
            {
                Console.BackgroundColor = ConsoleColor.Red; //method of changing colour
                Console.ForegroundColor = ConsoleColor.White;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo)) //if the type is directory change the colour to white black
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

            }
            else //else it it is a file, then change the colour to black yellow
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);

            //here it gives numeration by getting size of directory and by looping through directories
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            FileSystemInfo[] curfs = directory.GetFileSystemInfos();
            int pos = 0;
            int tt = 1; //first variable to get numeration is equal to 1 
            for (int i = 0; i < curfs.Length; ++i) //loop through the array 
            {
                if (ok == false && curfs[i].Name[0] == '.') //it shows not hidden directories
                {
                    continue;
                }
                if (curfs[i] is DirectoryInfo) //shows only directory first
                {
                    fs[pos++] = curfs[i];
                }
            }
            for (int i = 0; i < curfs.Length; ++i)
            {
                if (ok == false && curfs[i].Name[0] == '.')
                {
                    continue;
                }
                if (curfs[i] is FileInfo)//shows only files first
                {
                    fs[pos++] = curfs[i];
                }
            }


            for (int i = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                if (fs[i] is DirectoryInfo)
                {
                    string ss = Convert.ToString(tt);
                    Color(fs[i], i);//changes colour of directories  according to their type
                    Console.WriteLine(ss + ". " + fs[i].Name); //show names of directories 
                    tt++; // numeration

                }
            }

            for (int i = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                if (fs[i] is FileInfo)
                {
                    string ss = Convert.ToString(tt);
                    Color(fs[i], i); //changes colour of files  according to their type
                    Console.WriteLine(ss + ". " + fs[i].Name); //show names of files 
                    tt++; //with numeration
                    //so directories and files are shown with numeration, then we start to control in the given directory by deleting, renaming and etc.
                }
            }


        }

        public void Delete() //function to delete directories
        {
            for (int i = 0; i < directory.GetFileSystemInfos().Length; i++) //loop through the directories and files
            {
                if (cursor == i) //if the file is chosen
                {
                    try
                    {
                        directory.GetFileSystemInfos()[i].Delete(); //then delete it
                        break;
                    }
                    catch (Exception ex) //Exception
                    {
                        Console.Write("Cannot get an access"); //shows message
                        Console.ReadKey();
                    }
                }
            }
        }

        public void Open()
        {
            FileInfo fileinf = new FileInfo(path);


            Console.Clear(); 
            try
            {
                using (StreamReader reader = new StreamReader(@"" + fileinf.FullName + "" + @"\" + directory.GetFileSystemInfos()[cursor]))
                {

                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }


                        Console.WriteLine(line); // Use line.

                    }
                    Console.ReadKey();
                }
            }

            catch (Exception ex)
            {
                Console.Write("Not txt file");
                Console.ReadKey();
            }

        }


        public void Rename() 
        {

            FileInfo fileinf = new FileInfo(path);
            FileSystemInfo fn = directory.GetFileSystemInfos()[cursor];
            if (fn is DirectoryInfo)
            {
                try
                {
                    Console.WriteLine("Set name for " + fileinf.FullName + @"\" + directory.GetFileSystemInfos()[cursor]);
                    string str = Console.ReadLine();
                    string old_name = @"" + fileinf.FullName + @"\" + directory.GetFileSystemInfos()[cursor];//get the name of file
                    string new_name = @"" + fileinf.FullName + @"\" + str;//get the adjusted name 
                    Directory.Move(old_name, new_name);//changes the name
                }

                catch (Exception ex)
                {
                    Console.Write("Name cannot be same or empty");
                    Console.ReadKey();
                }

            }
            else
            {
                try
                {
                    Console.WriteLine("Set name for " + fileinf.FullName + @"\" + directory.GetFileSystemInfos()[cursor]);
                    string str = Console.ReadLine();

                    File.Move(@"" + fileinf.FullName + @"\" + directory.GetFileSystemInfos()[cursor], @"" + fileinf.FullName + @"\" + str);



                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.Write("Cannot get an access");
                    Console.ReadKey();
                }
            }


        }

        public void Up()
        {
            cursor--;//goes up
            if (cursor < 0) //if it is in the beginning and up arraw is pressed
                cursor = sz - 1;//then cursor goes to the end
        }
        public void Down()
        {
            cursor++;//goes down
            if (cursor == sz)//if it is in the end and down  arraw is pressed
                cursor = 0;//it goes to the beginning
        }
        public void CalcSz()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }
        public void Start() //main function to work with directories
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                CalcSz();
                Show();
                consoleKey = Console.ReadKey(); //displays while pressing any key

                if (consoleKey.Key == ConsoleKey.Delete) 
                    Delete(); //deletes directory while pressing Delete



                if (consoleKey.Key == ConsoleKey.O)
                    Open(); //opens directory while pressing O

                if (consoleKey.Key == ConsoleKey.R)
                    Rename();//renames directory while pressing R


                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();//goes up while pressing UpArray
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down(); //goes down while pressing DownArray
                if (consoleKey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0; //stays in place
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true; //cursor goes to the begining
                }
                if (consoleKey.Key == ConsoleKey.Enter) //if you press the Enter
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo)) //open in-directories
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    try
                    {
                        cursor = 0;
                        path = directory.Parent.FullName; //opens parent directory(goes back)
                    }
                    catch (Exception ex) //if it is on the root directory it cannot go back
                    {
                        Console.Write("Cannot move back");
                        Console.ReadKey();
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\"; //set path
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}