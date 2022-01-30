using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9 {

  struct _thread {
    public int index;
    public long start;
    public long finish;
  }
  public partial class Form1: Form {

    static List < decimal > toplamlar;
    static long sayi = 10000000000;
    static long time = 0;
    bool bitti = false;
    List < long > times = new List < long > ();
    public Form1() {
      InitializeComponent();
    }
    private void btnThreadBaslat_Click(object sender, EventArgs e) 
    {
      basla();
      if (bitti) 
      {
        MessageBox.Show("Thread işlemi başarıyla tamamlandı. Grafik çizdirebilirsiniz.", "İşlem tamamlandı");
        btnGrafikCiz.Visible = true;
      }
    }
    private void btnGrafikCiz_Click(object sender, EventArgs e) 
    {
      for (int i = 1; i <= 32; i++)
      chart1.Series["time"].Points.AddXY(i, times[i - 1]);
      chart1.ChartAreas[0].AxisX.Interval = 1;
      chart1.ChartAreas[0].AxisX.Minimum = 1;
      chart1.ChartAreas[0].AxisX.Title = "THREAD SAYISI";
      chart1.ChartAreas[0].AxisX.Maximum = 32;
      chart1.ChartAreas[0].AxisY.Interval = 5000;
      chart1.ChartAreas[0].AxisY.Minimum = 7000;
      chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
      chart1.ChartAreas[0].AxisY.Title = "ZAMAN (ms)";
    }
    void Toplam(object paramaters) 
     {
      _thread t = (_thread) paramaters;
      decimal toplam = 0;
      var sw = Stopwatch.StartNew();
      for (long i = t.start; i <= t.finish; i++) 
        toplam = toplam + i;
      sw.Stop();
      toplamlar[t.index] = toplam;
      time = sw.ElapsedMilliseconds;
    }
    void gauss() 
    {
      decimal cevap;
      var sw = Stopwatch.StartNew();
      cevap = Convert.ToDecimal(sayi)*(sayi+1) / 2;
      sw.Stop();
      lb_threadinfo.Items.Add("Gauss sonucu=" + cevap + "   " + sw.ElapsedMilliseconds + " ms");
    }
    void basla() 
    {
      //normalTopla();     Hesaplanması 3-4 saat sürdüğü için yorumda bırakıldı.
      new Thread(gauss).Start();
      for (int threadsayisi = 1; threadsayisi <= 32; threadsayisi++) {
        List < Thread > threads = new List < Thread > ();
        toplamlar = new List < decimal > ();
        _thread t1 = new _thread();
        long temp = sayi / threadsayisi;
        t1.start = 1;
        t1.finish = temp;

        for (int i = 0; i < threadsayisi; i++) 
        {
          toplamlar.Add(0);
          t1.index = i;
          _thread t2 = t1;
          threads.Add(new Thread(Toplam));
          threads[i].Start(t2);
          t1.start = t1.finish + 1;
          t1.finish = t1.start + temp;
          if (t1.finish > sayi)
            t1.finish = sayi;
        }
        foreach(var item in threads)
          item.Join();
        decimal toplam = 0;
        foreach(var item in toplamlar)
          toplam = toplam + item;
        lb_threadinfo.Items.Add(threadsayisi + " iplik icin sonuç=" + toplam + " " + time + " ms");
        times.Add(time);
        bitti = true;
      }
    }
    void normalTopla()
    {
            decimal toplam = 0;
            for (long i = 1; i < sayi; i++)
                toplam += i;
            lb_threadinfo.Items.Add("Standart yöntem sonuç:" + toplam);
    }
  }
}
