using System;
using System.IO;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger pt 2");
                Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
            }else {

                String outFile = args[args.Length - 1];  
                StreamWriter swrite = new StreamWriter(outFile); 
                try{
                    String line;
                    int i = 0;
                    while (i < (args.Length - 1)){
                        
                     
                        using (StreamReader sread = new StreamReader(args[i]))
                        {
                            while ((line = sread.ReadLine()) != null)
                            {
                                swrite.WriteLine(line);
                            }
                        }
                        i++;
                    }                     
               
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception" + e.Message);
                    Console.WriteLine("End of Program.");
                }
                finally {
                    swrite.Close();
                }

             }
            
        }
    }
}
