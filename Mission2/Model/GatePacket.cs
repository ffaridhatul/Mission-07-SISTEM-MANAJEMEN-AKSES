using System;
using System.Collections.Generic;
using System.IO;

namespace Mission2.Model
{
    public abstract class GatePacket
    {
        protected const string ENTER = "E";
        protected const string LEAVE = "L";

        public string PacketString { get; set; }

        public static List<GatePacket> ReadFromFile()
        {
            var packetList = new List<GatePacket>();
            string filePath = "Packet.txt";

            try
            {
                // Pastikan file ada sebelum melanjutkan
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found.");
                    return packetList;
                }

                // Buka file Packet.txt dan baca baris demi baris
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("A"))
                        {
                            // Membuat objek dari kelas GatePacketProtocolA
                            var packet = new GatePacketProtocolA
                            {
                                PacketString = line
                            };
                            // Menambahkan objek ke koleksi packetList
                            packetList.Add(packet);
                        }
                        else if (line.StartsWith("B"))
                        {
                            // Membuat objek dari kelas GatePacketProtocolB
                            var packet = new GatePacketProtocolB
                            {
                                PacketString = line
                            };
                            // Menambahkan objek ke koleksi packetList
                            packetList.Add(packet);
                        }
                    }
                }

                // Menghapus file setelah selesai membaca
                File.Delete(filePath);
            }
            catch (Exception ex)
            {
                // Menangani kesalahan jika terjadi
                Console.WriteLine($"An error occurred while reading from file: {ex.Message}");
            }

            // Mengembalikan koleksi packetList
            return packetList;
        }

        public abstract RecordTypeEnum GetAccessType();

        public abstract string GetCardId();

        public abstract int GetGateId();

        public abstract DateTime GetRecordDate();
    }
}
