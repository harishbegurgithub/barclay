using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Please pass the arguments");
                    return;
                }
                string argType = Convert.ToString(args[0]); // getting first argument, to check type either version or size
                string filePath = Convert.ToString(args[1]); //getting filapath

                CheckargType(argType, filePath);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Details:" + ex.StackTrace);
            }

        }
        /// <summary>
        /// Method to check the type of argType and call respective methods
        /// </summary>
        /// <param name="argType"></param>
        /// <param name="filePath"></param>
        public static void CheckargType(string argType, string filePath)
        {
            try
            {
                //check if argType is version then call Version() else Size()
                if (argType == "-v" || argType == "--v" || argType == "/v" || argType == "-version")
                {
                    GetVersion(filePath);
                }
                else if (argType == "-s" || argType == "--s" || argType == "/s" || argType == "-size")
                {
                    GetSize(filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Details:" + ex.StackTrace);
            }

        }
        /// <summary>
        /// Method to retrieve Version of file
        /// </summary>
        /// <param name="filePath"></param>
        public static string GetVersion(string filePath)
        {
            //creating an instancce of FileDetails class
            FileDetails objFileDet = new FileDetails();
            Console.Write(objFileDet.Version(filePath));
            return objFileDet.Version(filePath);
        }
        /// <summary>
        /// Method to retrieve size of file
        /// </summary>
        /// <param name="filePath"></param>
        public static int GetSize(string filePath)
        {
            //creating an instancce of FileDetails class
            FileDetails objFileDet = new FileDetails();
            Console.Write(objFileDet.Size(filePath));
            return objFileDet.Size(filePath);
        }

    }
}
