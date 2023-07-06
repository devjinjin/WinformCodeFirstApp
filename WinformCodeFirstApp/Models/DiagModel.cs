using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
    /// 고장 진단 데이터
    /// Key off시 
    /// </summary>
    public class DiagModel
    {
        [Key]
        public long ID { get; set; }
        /*고장 진단 데이터 1초*/
        public ushort? bV { get; set; }
        public short? bC { get; set; }
        public byte? vehS { get; set; }
        public byte? tht { get; set; }
        public byte? tarT { get; set; }
        public byte  actT { get; set; }

        /* 고장 진단 데이터 10초 */
        public short? watT { get; set; }
        public short? mcufT { get; set; }
        public short? coilT { get; set; }
        public sbyte? b0T { get; set; }
        public sbyte? b1T { get; set; }
        public sbyte? b0fT { get; set; }
        public sbyte? b1fT { get; set; }

        /*고장 진단 데이터 60초*/
        public byte? soc0 { get; set; }
        public byte? soc1 { get; set; }
        public ushort? avaD { get; set; }

        /*고장 진단 데이터 이벤트 변경 (diag)*/
        public bool brkB { get; set; }
        public uint? brkB_T { get; set; }

        public bool? regB { get; set; }

        public uint? regB_T { get; set; }
        public byte? bstS { get; set; }
        public uint? bstS_T { get; set; }
        public byte? bms0S { get; set; }
        public uint? bms0S_T { get; set; }
        public byte? bms1S { get; set; }
        public uint? bsm1S_T { get; set; }
        public byte? mcuS { get; set; }
        public uint? mcuS_T { get; set; }
        public byte? vcuS { get; set; }
        public uint? vcuS_T { get; set; }
        public byte[]? err { get; set; }
        public uint? err_T { get; set; }
    }
}
