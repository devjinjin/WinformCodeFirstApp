using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    uint8_t equivalent to :point_right: byte or Byte (unsigned byte).
int8_t equivalent to :point_right: byte or SByte (signed byte).
uint16_t equivalent to :point_right: ushort (unsigned short).
int16_t equivalent to :point_right: short (signed short).
uint32_t equivalent to :point_right: uint (unsigned integer).
int32_t equivalent to :point_right: int (signed integer).

    https://swjman.tistory.com/48
     */

    /// <summary>
    /// 차량 상태 데이터
    /// key on Key off event
    /// </summary>
    public class StatusModel
    {
        [Key]
        public long ID { get; set; }

        public byte? soc0 { get; set; } //ok
        public byte? soc1 { get; set; } //ok
        public ushort? avaD { get; set; } //ok
        public byte? tp0 { get; set; } //ok
        public byte? tp1 { get; set; } //ok

        [Column(TypeName = "decimal(10, 6)")]
        public decimal? glatI { get; set; }//ok uint -> decimal
        public sbyte? glatD { get; set; }//ok

        [Column(TypeName = "decimal(10, 6)")]
        public decimal? glonI { get; set; }//ok  uint -> decimal
        public sbyte? glonD { get; set; }//ok

        public bool? gpsS { get; set; }//bool -> byte //갑자기 배열? (값사용하지 않음)

        [JsonPropertyName("lock")]
        public bool? _lock { get; set; }//bool

        public string? b1ID { get; set; }//이상 ushort[] -> string
        public string? b2ID { get; set; }//이상 ushort[]  -> string

        public bool? mstat { get; set; }//이상  bool -> byte
    }
}
