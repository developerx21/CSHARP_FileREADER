using System;
using System.IO;

namespace reader{
  class Programm{
    static void Main(string[] args){
      Console.WriteLine("Hello!");
      Console.WriteLine("Write your file directory \n e.g. D://Folder//test.txt");
      while(true){
        if(System.IO.File.Exists(file_name){
          string file_name = Console.ReadLine();
          System.Diagnostics.Process.Start(file_name);
        }else{
          Console.WriteLine("File Name is not exists");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
      }
    }
  }
}
