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
    /// Key off시 
    /// </summary>
    public class DrivingModel
    {
        [Key]
        public long ID { get; set; }

        /* 주행 정보 데이터 */
        public ushort? raN { get; set; }
        public ushort? rdN { get; set; }
        public byte? avDS { get; set; }
        public byte? mxDS { get; set; }
        public byte? aveE { get; set; }
        public ushort? idlT { get; set; }
        public float? driD { get; set; } // ushort -> float
        public uint? totD { get; set; }

        //public object b1ID { get; set; } // ushort[] -> string  //갑자기 배열 존재함


        //public object b2ID { get; set; } // ushort[] -> string  //갑자기 배열 존재함
        

       //[JsonConverter(typeof(ByteArrayConverter))]
        //public object? err { get; set; } //Convert 사용해야함

        public string? onT { get; set; } //문서 타입 없음 ushort -> string
        public string? offT { get; set; } //문서 타입 없음 ushort -> string

        /* 주행 정보 데이터 100m */
        //public object? glatI { get; set; } //갑자기 배열 존재함 ??
        //public object? glatD { get; set; }//중간에 배열이 존재함

        //public object? glonI { get; set; } //갑자기 배열 존재함
        //public object? glonD { get; set; } //갑자기 배열 존재함

        ////[JsonConverter(typeof(NumberToBooleanConverter))]
        //public object? gpsS { get; set; } //문서랑 상이함 bool -> byte , 중간에 배열이 존재함 (값사용하지 않음)


        //public object? avS { get; set; } //중간에 배열이 존재함 byte


        //public object? mxS { get; set; }//중간에 배열이 존재함 byte

    }//C:\ProgramData\Microsoft\Windows\Start Menu\Programs
}
