using System;

namespace Mission2.Model
{
    public class GatePacketProtocolB : GatePacket
    {
        public override RecordTypeEnum GetAccessType()
        {
            // Lihat struktur paket yang diterapkan oleh protokol dan dapatkan satu karakter
            // Mengembalikan RecordTypeEnum.Enter jika pintu sama dengan konstanta ENTER
            // Mengembalikan RecordTypeEnum.Leave jika sama dengan konstanta LEAVE
            if (PacketString.Substring(9, 1) == ENTER)
            {
                return RecordTypeEnum.Enter;
            }

            return RecordTypeEnum.Leave;
        }

        public override string GetCardId()
        {
            // Memotong dan mengembalikan string yang sesuai dengan CardID
            return PacketString.Substring(3, 6);
        }

        public override int GetGateId()
        {
            // Memotong dan mengembalikan string yang sesuai dengan GateID
            string gateId = PacketString.Substring(1, 2);
            return int.Parse(gateId);
        }

        public override DateTime GetRecordDate()
        {
            // Memotong string yang sesuai dengan tanggal catatan, mengonversinya menjadi DateTime
            string recordDate = PacketString.Substring(10);
            return DateTime.Parse(recordDate);
        }
    }
}
