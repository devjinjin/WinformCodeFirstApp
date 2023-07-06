using System.ComponentModel.DataAnnotations;

namespace WinformCodeFirstApp.Models
{
    /*

 boolean_T = bool
int16_T = short
int8_T = sbyte
uint16_T = ushort
uint32_T = uint
uint8_T = byte

https://swjman.tistory.com/48
 */
    /// <summary>
    /// 모니터링 데이터
    /// Key Off
    /// </summary>
    public class MonitorModel
    {

        [Key]
        public long ID { get; set; }
        public short? mxWT { get; set; }
        public short? mxCT { get; set; }
        public short? mxMT { get; set; }
        public byte? mxTA { get; set; }
        public byte? mnTA { get; set; }
        public ushort? brkN { get; set; }
        public ushort? ewpT { get; set; }
        public ushort? sopT { get; set; }
        public ushort? limB { get; set; }
        public byte? dm1T { get; set; }
        public byte? dm2T { get; set; }
        public byte? dm3T { get; set; }
        public short? mxMR { get; set; }
        public sbyte? mxb1T { get; set; }
        public sbyte? mnb1T { get; set; }
        public sbyte? mxb2T { get; set; }
        public sbyte? mnb2T { get; set; }
        public byte? b1lf { get; set; }
        public byte? b2lf { get; set; }
        public byte? mxbV { get; set; }
        public byte? mnbV { get; set; }
        public byte? mxbc0V { get; set; }
        public byte? mnbc0V { get; set; }
        public byte? mxbc1V { get; set; }
        public byte? mnbc1V { get; set; }
        public uint? bcID { get; set; }
        public sbyte? bc { get; set; }
        public sbyte? mcc { get; set; }
        public sbyte? bcc { get; set; }
        public ushort? sbV { get; set; }
        public uint? kyID { get; set; }

    }
}
