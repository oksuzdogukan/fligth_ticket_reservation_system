using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Models;

namespace TicketReservation.Business.Abstract
{
    public interface IRezervasyonService
    {
        bool RezervasyonYap(Rezervasyon rezervasyon);

        List<Ucus> MusteriUcusAra(string kalkis, string varis);

        List<Koltuk> KoltuklariGetir(int ucusId); // Koltuk secme ekrani icin 

        bool RezervasyonIptalEt(int rezervasyonId);

        List<Rezervasyon> RezervasyonGoruntule(int musteriId);

        decimal DinamikFiyatHesapla(Ucus ucus, List<Koltuk> koltuklar, bool isBusiness=false, string kuponKodu = null);
        decimal KoltukFiyatiHesapla(decimal temelFiyat, bool isBusiness);
        decimal KuponIndirimiHesapla(string kuponKodu, decimal guncelFiyat);

        // raporlama
        Dictionary<string, object> RaporGetir();

    }
}
