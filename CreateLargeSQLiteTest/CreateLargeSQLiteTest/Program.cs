using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace CreateLargeSQLiteTest
{
    class Program
    {

        static string _sourceFile = @"D:\Progetti\Repos\CreateLargeSQLiteTest\Storage\DispositiviSovracomunali.csv";
        static string _destinationDb = @"D:\Progetti\Repos\CreateLargeSQLiteTest\Storage\DispositiviSovracomunali.sqlite";


        /// <summary>
        /// Lo scopo è convertire un file csv di grandi dimensioni (si trova in formato compresso nella directory del progetto,
        /// e consta di 1.400.000 righe) in un database SQLite contenente una sola tabella che contenga i dati caricati.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Verifica presenza file sorgente...");
            if (!File.Exists(_sourceFile))
            {
                Console.WriteLine("FALLITA!");
                return;
            }
            Console.WriteLine("OK!");

            Console.Write("Eliminazione DB destinazione precedente...");

            SqliteTransaction tr = null;
            SqliteConnection conn = null;

            try
            {
                if (File.Exists(_destinationDb)) 
                {
                    File.Delete(_destinationDb);
                }
                Console.WriteLine("OK!");

                Console.Write("Creazione base dati...");

                var creator = new SqliteConnectionStringBuilder();
                creator.DataSource = _destinationDb;

                conn = new SqliteConnection(creator.ConnectionString);
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = GetSchema();
                cmd.ExecuteNonQuery();

                Console.WriteLine("OK!");

                Console.Write("Copia dei dati...");

                var i = -1;

                var rows = File.ReadAllLines(_sourceFile);
                tr = conn.BeginTransaction();
                cmd.Transaction = tr;

                foreach(var row in rows)
                {
                    if (i == -1)
                    {
                        i = 0;
                        continue;
                    }
                    if (i == 5000)
                    {
                        i = 0;
                        tr.Commit();
                        tr = conn.BeginTransaction();
                        cmd.Transaction = tr;
                        Console.Write(".");
                    }
                    i++;
                    cmd.CommandText = GetInsertStatement(row);
                    cmd.ExecuteNonQuery();
                }
                tr.Commit();
                Console.WriteLine("OK!");
            }
            catch(Exception e)
            {
                Console.WriteLine("FALLITA!");
                if (tr != null)
                {
                    tr.Rollback();
                }
                return;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public static string GetSchema()
        {
            return
                "CREATE TABLE DispositiviSovracomunali (" +
                    "IDDispositivo INTEGER, " +
                    "IdAzienda INTEGER, " +
                    "IdComune INTEGER, " +
                    "IdAttrezzatura INTEGER, " +
                    "CodiceDispositivo TEXT, " +
                    "DescrizioneDispositivo TEXT, " +
                    "StatoFunzionamento TEXT, " +
                    "IdMagazzino INTEGER, " +
                    "IdFornitore INTEGER, " +
                    "CoordGPSlong TEXT, " +
                    "CoordGPSlat TEXT, " +
                    "Note TEXT, " +
                    "IsAttivo INTEGER, " +
                    "DateInsert TEXT, " +
                    "DateDelete TEXT, " +
                    "DateLastUpdate TEXT, " +
                    "KeyTemp TEXT, " +
                    "IdTipoRifiuto INTEGER, " +
                    "Quantita REAL, " +
                    "IdMagazzinoImportati INTEGER, " +
                    "UniqueKeyAzDispositivo TEXT, " +
                    "MagazziniImportatiDispositivi_CodRifiuto TEXT, " +
                    "MagazziniImportatiDispositivi_CodAtrezzatura TEXT, " +
                    "Equipment TEXT " +
                ");";
        }

        static string GetInsertStatement(string sourceStr)
        {
            string[] splitted = sourceStr.Split(';');

            Func<string, string> NullIfEmpty = (s) => (s.Length > 0) ? s : "NULL";

            return
                "INSERT INTO DispositiviSovracomunali VALUES (" +
                $"{NullIfEmpty(splitted[0])}," +
                $"{NullIfEmpty(splitted[1])}," +
                $"{NullIfEmpty(splitted[2])}," +
                $"{NullIfEmpty(splitted[3])}," +
                $"'{splitted[4]}'," +
                $"'{splitted[5]}'," +
                $"'{splitted[6]}'," +
                $"{NullIfEmpty(splitted[7])}," +
                $"{NullIfEmpty(splitted[8])}," +
                $"'{splitted[9]}'," +
                $"'{splitted[10]}'," +
                $"'{splitted[11]}'," +
                $"{((splitted[12] == "True") ? 1 : 0).ToString() }," +
                $"'{splitted[13]}'," +
                $"'{splitted[14]}'," +
                $"'{splitted[15]}'," +
                $"'{splitted[16]}'," +
                $"{NullIfEmpty(splitted[17])}," +
                $"{NullIfEmpty(splitted[18].Replace(',', '.'))}," +
                $"{NullIfEmpty(splitted[19])}," +
                $"'{splitted[20]}'," +
                $"'{splitted[21]}'," +
                $"'{splitted[22]}'," +
                $"'{splitted[23]}'" +
                ")";
        }

    }
}
