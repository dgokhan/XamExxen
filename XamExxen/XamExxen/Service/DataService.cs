using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamExxen.Models;

namespace XamExxen.Service
{
    public class DataService
    {
        public static ObservableCollection<KeepWatching> GetKeepWatching()
        {
            return new ObservableCollection<KeepWatching>()
            {
                new KeepWatching
                {
                    Id = 1,
                    SeasonNumber = 2,
                    EpisodeNumber = 7,
                    SeriesName = "Şeref Bey",
                    SeriesImage = "SerefBey.jpg",
                    SeriesDescription = "O romantik ve hassas olduğu kadar prensiplerine sıkı sıkıya bağlı ve son derece inatçı. Arnavutluk'tan Türkiye'ye göç eden ve en iyi aşçılar arasında gösterilen Şeref Bey bu kez yeni bir hayat için yola çıkıyor ama hiç beklemediği sürprizler ve kim bilir belki de yeni bir aşk onu bekliyor.  Şeref  Bey, yeni bölümleriyle her Pazartesi yayında!",
                    SeriesGenre = "Komedi",
                    SeriesYear = "2021",
                    PercentageOfWatch = 75,
                    Cast = new ObservableCollection<Cast>{ new Cast
                        {
                             CastFirstName = "Haluk",
                             CastLastname = "BİLGİNER",
                             CastImage = "HalukBilginer.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Songül",
                             CastLastname = "ÖDEN",
                             CastImage = "SongulOden.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Ertan",
                             CastLastname = "SABAN",
                             CastImage = "ErtanSaban.png",
                        }}
                },
                new KeepWatching
                {
                    Id = 2,
                    SeasonNumber = 1,
                    EpisodeNumber = 5,
                    SeriesName = "Süprizimiz Var",
                    SeriesImage = "SuprizimizVar.jpg",
                    SeriesDescription = "Bir hayalin gerçek olduğu anlara tanık olmak ister misiniz? Peki, bugün en sevdiklerinizin hayallerini gerçekleştirmeye ne dersiniz? Bu    program hem sürpriz yapanı, hem de sürpriz yapılanı mutlu ediyor. Acun Ilıcalı'nın sürprizlerine hazır olun!",
                    SeriesGenre = "Reality",
                    SeriesYear = "2021",
                    PercentageOfWatch = 15,
                    Cast = new ObservableCollection<Cast>{ new Cast
                        {
                             CastFirstName = "Alp",
                             CastLastname = "KIRŞAN",
                             CastImage = "AlpKirsan.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Acun",
                             CastLastname = "Ilıcalı",
                             CastImage = "AcunIlicali.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Esra",
                             CastLastname = "Eron",
                             CastImage = "EsraEron.png",
                        }}
                },
                new KeepWatching
                {
                    Id = 3,
                    SeasonNumber = 1,
                    EpisodeNumber = 5,
                    SeriesName = "Tolgshow Filtresiz",
                    SeriesImage = "TolgShowFiltresiz.jpg",
                    SeriesDescription = "Arkadaşım yepyeni bir sezona,yepyeni bir enerjiyle başlıyor. Yönetmenle bitmek tükenmek bilmeyen atışmaları her zamankinden daha eğlenceli.    Hem de filtresiz!",
                    SeriesGenre = "Komedi",
                    SeriesYear = "2021",
                    PercentageOfWatch = 120,
                    Cast = new ObservableCollection<Cast>{ new Cast
                    {
                         CastFirstName = "Tolga",
                         CastLastname = "Çevik",
                         CastImage = "TolgaCevik.png",
                    }}
                },
                new KeepWatching
                {
                    Id = 4,
                    SeasonNumber = 1,
                    EpisodeNumber = 18,
                    SeriesName = "Konuşanlar",
                    SeriesImage = "Konusanlar.png",
                    SeriesDescription = "Bu sohbet bildiklerinizden çok farklı. Her insan farklı bir hikaye, her hikaye fark!..",
                    SeriesGenre = "Stand-up, Komedi",
                    SeriesYear = "2021",
                    PercentageOfWatch = 25,
                    Cast = new ObservableCollection<Cast>{ new Cast
                    {
                         CastFirstName = "Hasan Can",
                         CastLastname = "KAYA",
                         CastImage = "HasanCanKaya.png",
                    }}
                }
            };
        }

        public static ObservableCollection<EditorsRecommendation> GetEditorsRecommendations()
        {
            return new ObservableCollection<EditorsRecommendation>()
            {
                new EditorsRecommendation
                {
                    Id = 10000,
                    SeriesName = "Milli Takım Hikayesi",
                    SeriesImage = "MilliTakimHikayesiIcerik.png",
                    SeriesPosterImage = "MilliTakimHikayesi.jpg",
                    SeriesDescription = "2008 Avrupa Kupası'ndaki efsane geri dönüşlerle tüm dünyayı kendine hayran bırakan Türk Mlli Takımı'nın kahramanları, o günleri kendi ağızlarından anlatıyor.",
                    SeriesGenre = "Futbol, Spor",
                    SeriesYear = "2021",
                    Cast = new ObservableCollection<Cast>{ new Cast
                        {
                             CastFirstName = "Fatih",
                             CastLastname = "TERİM",
                             CastImage = "FatihTerim.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Nihat",
                             CastLastname = "KAHVECİ",
                             CastImage = "NihatKahveci.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Arda",
                             CastLastname = "TURAN",
                             CastImage = "ArdaTuran.png",
                        }
                    }
                },
                new EditorsRecommendation
                {
                    Id = 10001,
                    SeriesName = "Sihirli Annem",
                    SeriesImage = "SihirliAnnemIcerik.png",
                    SeriesPosterImage = "SihirliAnnem.jpg",
                    SeriesDescription = "Çocuklarıyla 'sıradan' bir yaşam süren Sadık'ın hayatı, Betüş'le tanışmasıyla hiç tahmin edemeyeceği bir şekilde değişecek. Neden mi? Sadık ve çocukların bilmediği bir 'sır' var. Betüş hem insan, hem de bir peri… Sihirli Annem, yeni bölümleriyle her Cuma yayında!",
                    SeriesGenre = "Fantastik, Aile",
                    SeriesYear = "2021",
                    Cast = new ObservableCollection<Cast>{ new Cast
                        {
                             CastFirstName = "Emre",
                             CastLastname = "ALTUĞ",
                             CastImage = "EmreAltug.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Açelya",
                             CastLastname = "TOPALOĞLU",
                             CastImage = "AcelyaTopaloglu.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Nergis",
                             CastLastname = "KUMBASAR",
                             CastImage = "NergisKumbasar.png",
                        }
                    }
                },
                new EditorsRecommendation
                {
                    Id = 10002,
                    SeriesName = "Zeynep Bastık",
                    SeriesImage = "ZeynepBastikIcerik.png",
                    SeriesPosterImage = "ZeynepBastikPoster.jpg",
                    SeriesDescription = "Zeynep Bastik, misafirlerine özel sürprizlerle hem onları hem de seyirciyi evinde bir müzik şölenine davet ediyor.",
                    SeriesGenre = "Müzik, Talk-Show",
                    SeriesYear = "2021",
                    Cast = new ObservableCollection<Cast>{ new Cast
                        {
                             CastFirstName = "Zeynep",
                             CastLastname = "BASTIK",
                             CastImage = "ZeynepBastik.png",
                        }
                    }
                },
                new EditorsRecommendation
                {
                    Id = 10003,
                    SeriesName = "GibiPoster",
                    SeriesImage = "GibiIcerik.png",
                    SeriesPosterImage = "GibiPoster.jpg",
                    SeriesDescription = "Yılmaz ve İlkkan, sürekli olarak birbiriyle didişmekte olan iki arkadaş. En büyük özellikleri ise sıradan hayatlarını altüst edecek bir şeyler yapmayı her zaman becermek. Küçücük olayları inanılmaz bir ustalıkla büyütüyor, işleri saç baş yolduracak seviyeye getiriyorlar. Onlar her gün yaşadığımız talihsizliklerin, tuhaf olayların ve çaresizliklerin cisimleşmiş hali. Yılmaz ve İlkkan'ın 12 farklı hikayeden oluşan macerasına hazır olun. Gibi, yeni bölümleriyle her Perşembe yayında!",
                    SeriesGenre = "Komedi",
                    SeriesYear = "2021",
                    Cast = new ObservableCollection<Cast>{ new Cast
                        {
                             CastFirstName = "Feyyaz",
                             CastLastname = "YİĞİT",
                             CastImage = "FeyyazYigit.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Kıvanç",
                             CastLastname = "KILINÇ",
                             CastImage = "KivancKilinc.png",
                        }
                    }
                },
                new EditorsRecommendation
                {
                    Id = 10004,
                    SeriesName = "Şeref Bey",
                    SeriesImage = "SerefBey.jpg",
                    SeriesPosterImage = "SerefBeyPoster.jpg",
                    SeriesDescription = "O romantik ve hassas olduğu kadar prensiplerine sıkı sıkıya bağlı ve son derece inatçı. Arnavutluk'tan Türkiye'ye göç eden ve en iyi aşçılar arasında gösterilen Şeref Bey bu kez yeni bir hayat için yola çıkıyor ama hiç beklemediği sürprizler ve kim bilir belki de yeni bir aşk onu bekliyor.  Şeref  Bey, yeni bölümleriyle her Pazartesi yayında!",
                    SeriesGenre = "Komedi",
                    SeriesYear = "2021",
                    Cast = new ObservableCollection<Cast>{ new Cast
                        {
                             CastFirstName = "Haluk",
                             CastLastname = "BİLGİNER",
                             CastImage = "HalukBilginer.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Songül",
                             CastLastname = "ÖDEN",
                             CastImage = "SongulOden.png",
                        },
                        new Cast
                        {
                             CastFirstName = "Ertan",
                             CastLastname = "SABAN",
                             CastImage = "ErtanSaban.png",
                        }
                    }
                }
            };
        }
    }
}
