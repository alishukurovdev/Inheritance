using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisAndBase;

namespace ThisAndBase
{
    public class Device
    { 
        public int Width {  get; set; }
        public int Height { get; set; }
        public int Weight {  get; set; }

        
        public void OpenDevice()
        {

        }
        public void CloseDevice()
        {

        }
    }
}
//Device classı var  ++
//Width, Height, Weight field-ları olur.  ++
//OpenDevice və CloseDevice voidləri var. ++
//Əgər DeviceOpen ilk dəfə və ya DeviceClose methodundan sonra işlənirsə ekrana “Device opening…” yazısını versin. 
//Əgər bir neçə dəfə ardıcıl olaraq çağırılıbsa “Device already opened” yazılsın. Qanuna uyğunluq DeviceClose voidi üçün də keçərlidir.
