using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, int> kodePos;

    public KodePos()
    {
        kodePos = new Dictionary<string, int>
        {
            {"Batununggal", 40266},
            {"Kujangsari", 40287},
            {"Mengger", 40267},
            {"Wates", 40256},
            {"Cijaura", 40287},
            {"Jatisari", 40286},
            {"Margasari", 40286},
            {"Sekejati", 40286},
            {"Kebonwaru", 40272},
            {"Maleer", 40274},
            {"Samoja", 40273}
        };
    }

    public int GetKodePos(string kelurahan)
    {
        if (kodePos.ContainsKey(kelurahan))
        {
            return kodePos[kelurahan];
        }
        else
        {
            Console.WriteLine("Kode pos tidak ditemukan");
            return -1;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePosObj = new KodePos();
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        int kodePos = kodePosObj.GetKodePos(kelurahan);
        if (kodePos != -1)
        {
            Console.WriteLine($"Kode Pos untuk {kelurahan}: {kodePos}");
        }
    }
}
