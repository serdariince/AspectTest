using System;
using System.Collections.Generic;
using Core.Aspect.Autofac.Logging;
using DataAccess.Concrete.EntitiyRepository;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Load
{
    public class SeedData
    {
        [LogAspect]
        public static void Initialize(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Çekirdek kurulum dosyaları çalıştırılıyor...");
            using (var _context = new EnvanterTakipContext())
            {
                _context.Database.Migrate();

                var tesisler = new[]
                {
                    new Tesis
                    {
                        Name = "Bozoklar", Adres = "Bozoklar Mah.",
                        Kameralar = new List<Kamera>
                        {
                            new Kamera
                            {
                                Marka = "Lg", Model = "w330", SeriNo = "123123", Ip = new Ip {IpName = "192.168.1.200"}
                            }
                        },
                        KayitProgrami = new KayitProgrami {Ad = "Digifort", Kanal = "5"}
                    },
                    new Tesis
                    {
                        Name = "Yaşar Torun", Adres = "60. Yıl Mah.",
                        Kameralar = new List<Kamera>
                        {
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.200"}
                            },
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.201"}
                            },
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.202"}
                            },
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.203"}
                            },
                            new Kamera
                            {
                                Marka = "Lg", Model = "w330", SeriNo = "123123", Ip = new Ip {IpName = "192.168.1.203"}
                            },
                            new Kamera
                            {
                                Marka = "Lg", Model = "w330", SeriNo = "123123", Ip = new Ip {IpName = "192.168.1.204"}
                            }
                        },
                        KayitProgrami = new KayitProgrami {Ad = "Dahua", Kanal = "8"}
                    },
                    new Tesis
                    {
                        Name = "Cumhuriyet", Adres = "Kolejtepe",
                        Kameralar = new List<Kamera>
                        {
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.200"}
                            },
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.201"}
                            },
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.202"}
                            },
                            new Kamera
                            {
                                Marka = "Wisenet", Model = "QNO-7080R", SeriNo = "123123",
                                Ip = new Ip {IpName = "192.168.1.203"}
                            },
                            new Kamera
                            {
                                Marka = "Lg", Model = "w330", SeriNo = "123123", Ip = new Ip {IpName = "192.168.1.203"}
                            },
                            new Kamera
                            {
                                Marka = "Lg", Model = "w330", SeriNo = "123123", Ip = new Ip {IpName = "192.168.1.204"}
                            }
                        },
                        KayitProgrami = new KayitProgrami {Ad = "Digifort", Kanal = "16"}
                    },
                    new Tesis
                    {
                        Name = "Onur Sosyal Tesisi", Adres = "Kolejtepe"
                    }
                };

                _context.Tesisler.AddRange(tesisler);
                _context.SaveChanges();
            }
        }
    }
}