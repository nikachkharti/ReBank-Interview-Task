using Microsoft.EntityFrameworkCore;
using NetworkManagementAPI.Entities;

namespace NetworkManagmentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PersonalIdentifier> PersonalIdentifiers { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DistributorSell> DistributorSells { get; set; }
        public DbSet<BonusHistory> BonusHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BonusHistory>()
                .HasOne(b => b.Distributor)
                .WithMany()
                .HasForeignKey(b => b.DistributorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BonusHistory>()
                .HasOne(b => b.DistributorSell)
                .WithMany()
                .HasForeignKey(b => b.SaleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Distributor>().HasData(
                    new Distributor
                    {
                        Id = 1,
                        FirstName = "Giorgi",
                        LastName = "Giorgadze",
                        BirthDate = new DateTime(1995, 2, 1),
                        Gender = Gender.Male,
                        Image = null,
                        RecomendatorId = 0,
                        RecomendationsCount = 0,
                        SubRecomendationsCount = 0
                    },
                    new Distributor
                    {
                        Id = 2,
                        FirstName = "Davit",
                        LastName = "Davitidze",
                        BirthDate = new DateTime(2000, 12, 23),
                        Gender = Gender.Male,
                        Image = null,
                        RecomendatorId = 0,
                        RecomendationsCount = 0,
                        SubRecomendationsCount = 0
                    },
                    new Distributor
                    {
                        Id = 3,
                        FirstName = "Anano",
                        LastName = "Ananiashvili",
                        BirthDate = new DateTime(1997, 3, 11),
                        Gender = Gender.Female,
                        Image = null,
                        RecomendatorId = 0,
                        RecomendationsCount = 0,
                        SubRecomendationsCount = 0
                    }
                );

            modelBuilder.Entity<Address>().HasData(
                    new Address
                    {
                        Id = 1,
                        AddressName = "Rustaveli 5",
                        AddressType = AddressType.Actual,
                        DistributorId = 1
                    },
                    new Address
                    {
                        Id = 2,
                        AddressName = "Rustaveli 6",
                        AddressType = AddressType.Legal,
                        DistributorId = 1
                    },
                    new Address
                    {
                        Id = 3,
                        AddressName = "Pekini 21",
                        AddressType = AddressType.Actual,
                        DistributorId = 2
                    },
                    new Address
                    {
                        Id = 4,
                        AddressName = "Kostava 13",
                        AddressType = AddressType.Actual,
                        DistributorId = 3
                    },
                    new Address
                    {
                        Id = 5,
                        AddressName = "Tsereteli 5",
                        AddressType = AddressType.Legal,
                        DistributorId = 3
                    }
                );

            modelBuilder.Entity<PersonalIdentifier>().HasData(
                    new PersonalIdentifier
                    {
                        Id = 1,
                        DocumentType = IdentityDocumentType.IDCard,
                        PersonalNumber = "0102487452",
                        DocumentSeries = "12345678",
                        DocumentNumber = "123",
                        ReleaseDate = new DateTime(2016, 10, 6),
                        ExpireDate = new DateTime(2016, 10, 6).AddYears(5),
                        IssuingAuthority = "Justice house",
                        DistributorId = 1
                    },
                    new PersonalIdentifier
                    {
                        Id = 2,
                        DocumentType = IdentityDocumentType.Passport,
                        PersonalNumber = "012589632",
                        DocumentSeries = "115632",
                        DocumentNumber = "332",
                        ReleaseDate = new DateTime(2010, 11, 6),
                        ExpireDate = new DateTime(2010, 11, 6).AddYears(5),
                        IssuingAuthority = "Justice house",
                        DistributorId = 1
                    },
                    new PersonalIdentifier
                    {
                        Id = 3,
                        DocumentType = IdentityDocumentType.IDCard,
                        PersonalNumber = "41587463983",
                        DocumentSeries = "115633",
                        DocumentNumber = "125",
                        ReleaseDate = new DateTime(2020, 5, 1),
                        ExpireDate = new DateTime(2010, 5, 1).AddYears(5),
                        IssuingAuthority = "Justice house",
                        DistributorId = 2
                    },
                    new PersonalIdentifier
                    {
                        Id = 4,
                        DocumentType = IdentityDocumentType.Passport,
                        PersonalNumber = "158965822",
                        DocumentSeries = "215633",
                        DocumentNumber = "658",
                        ReleaseDate = new DateTime(2020, 5, 1),
                        ExpireDate = new DateTime(2010, 5, 1).AddYears(5),
                        IssuingAuthority = "Justice house",
                        DistributorId = 3
                    }
                );

            modelBuilder.Entity<ContactInfo>().HasData(
                    new ContactInfo
                    {
                        Id = 1,
                        ContactType = ContactType.Telephone,
                        ContactNumber = "555338877",
                        DistributorId = 1
                    },
                    new ContactInfo
                    {
                        Id = 2,
                        ContactType = ContactType.Email,
                        ContactNumber = "giorgigiorgadze@gmail.com",
                        DistributorId = 1
                    },
                    new ContactInfo
                    {
                        Id = 3,
                        ContactType = ContactType.Email,
                        ContactNumber = "davit123@gmail.com",
                        DistributorId = 2
                    },
                    new ContactInfo
                    {
                        Id = 4,
                        ContactType = ContactType.Mobile,
                        ContactNumber = "551448877",
                        DistributorId = 2
                    },
                    new ContactInfo
                    {
                        Id = 5,
                        ContactType = ContactType.Mobile,
                        ContactNumber = "558776932",
                        DistributorId = 3
                    },
                    new ContactInfo
                    {
                        Id = 6,
                        ContactType = ContactType.Email,
                        ContactNumber = "anano@yahoo.com",
                        DistributorId = 3
                    },
                    new ContactInfo
                    {
                        Id = 7,
                        ContactType = ContactType.Fax,
                        ContactNumber = "123879",
                        DistributorId = 3
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Code = Guid.NewGuid().ToString(),
                        Title = "Iphone 12",
                        Price = 1549
                    },
                    new Product
                    {
                        Id = 2,
                        Code = Guid.NewGuid().ToString(),
                        Title = "Iphone 11",
                        Price = 1449
                    },
                    new Product
                    {
                        Id = 3,
                        Code = Guid.NewGuid().ToString(),
                        Title = "Iphone X",
                        Price = 1349
                    },
                    new Product
                    {
                        Id = 4,
                        Code = Guid.NewGuid().ToString(),
                        Title = "PS5",
                        Price = 2500
                    }
                );

            modelBuilder.Entity<DistributorSell>().HasData(
                    new DistributorSell
                    {
                        Id = 1,
                        DistributorId = 1,
                        SellDate = DateTime.Now,
                        ProductId = 1,
                        SellsCount = 1,
                        TotalPrice = 1549,
                        IsProcessed = false
                    },
                    new DistributorSell
                    {
                        Id = 2,
                        DistributorId = 2,
                        SellDate = DateTime.Now,
                        ProductId = 2,
                        SellsCount = 3,
                        TotalPrice = 4347,
                        IsProcessed = false
                    },
                    new DistributorSell
                    {
                        Id = 3,
                        DistributorId = 2,
                        SellDate = DateTime.Now,
                        ProductId = 3,
                        SellsCount = 1,
                        TotalPrice = 1449,
                        IsProcessed = false
                    },
                    new DistributorSell
                    {
                        Id = 4,
                        DistributorId = 3,
                        SellDate = DateTime.Now,
                        ProductId = 3,
                        SellsCount = 2,
                        TotalPrice = 5000,
                        IsProcessed = false
                    }
                );

            //modelBuilder.Entity<BonusHistory>().HasData(
            //        new BonusHistory
            //        {
            //            Id = 1,
            //            DistributorId = 1,
            //            SaleId = 1,
            //            DateCalculated = DateTime.Now,
            //            BonusAmount = 154.90m
            //        },
            //        new BonusHistory
            //        {
            //            Id = 2,
            //            DistributorId = 2,
            //            SaleId = 2,
            //            DateCalculated = DateTime.Now,
            //            BonusAmount = 434.70m
            //        },
            //        new BonusHistory
            //        {
            //            Id = 3,
            //            DistributorId = 2,
            //            SaleId = 3,
            //            DateCalculated = DateTime.Now,
            //            BonusAmount = 144.90m
            //        },
            //        new BonusHistory
            //        {
            //            Id = 4,
            //            DistributorId = 3,
            //            SaleId = 4,
            //            DateCalculated = DateTime.Now,
            //            BonusAmount = 500
            //        }
            //    );

        }
    }
}
