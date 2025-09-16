using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Data
{
    public class TrueDiveDeepContext : DbContext
    {

        public DbSet<Booking> Bookings { get; set; } 
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BCD> BCDs { get; set; }
        public DbSet<DivingSuit> DivingSuits { get; set; }
        public DbSet<Fin> Fins { get; set; }
        public DbSet<Mask_Snorkel> Mask_Snorkels { get; set; }
        public DbSet<RegulatorSet> RegulatorSets { get; set; }
        public DbSet<Tank> Tanks { get; set; }


        private static int _productIdCounter = -1;

        private static int GetNextProductId()
        {
            return _productIdCounter--;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cart>()
                .HasMany(c => c.Items)
                .WithOne(i => i.Cart)
                .HasForeignKey(i => i.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BCD>().ToTable("BCD");
            modelBuilder.Entity<DivingSuit>().ToTable("DivingSuit");
            modelBuilder.Entity<Fin>().ToTable("Fin");
            modelBuilder.Entity<Mask_Snorkel>().ToTable("Mask_Snorkel");
            modelBuilder.Entity<RegulatorSet>().ToTable("RegulatorSet");
            modelBuilder.Entity<Tank>().ToTable("Tank");

            modelBuilder.Entity<BCD>().HasData(
             new BCD
             {
                 ProductId = GetNextProductId(),
                 Brand = "Scubapro",
                 Model = "Navigator Lite BCD",
                 Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                 PricePerDay = 125,
                 ImageFileName = "navigatorliteblue.jpg"
             },
            new BCD
            {  ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "BCD Glide",
                Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                PricePerDay = 140,
                ImageFileName = "bcd02.jpg"
            },
            new BCD
            { ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "BCD Hydros Pro",
                Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                PricePerDay = 200,
                ImageFileName = "bcdhydrospro.png"
            },
            new BCD
            {
                ProductId = GetNextProductId(),
                Brand = "Seac",
                Model = "BCD Modular",
                Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                PricePerDay = 145,
                ImageFileName = "bcdmodular.jpg"
            }
            );

            modelBuilder.Entity<DivingSuit>().HasData(
                 new DivingSuit
                 {
                     ProductId = GetNextProductId(),
                     Brand = "Scubapro",
                     Model = "Definition",
                     Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                     Type = "Våddragt",
                     Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                     Thickness = 3,
                     PricePerDay = 100,
                     ImageFileName = "Dykkerdragter.webp"
                 },
            new DivingSuit
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "Definition",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                Thickness = 5,
                PricePerDay = 100,
                ImageFileName = "divingsuit5mm.webp"
            },
            new DivingSuit
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "Definition",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                Thickness = 7,
                PricePerDay = 100,
                ImageFileName = "divingsuit7mm.webp"
            },
            new DivingSuit
            {
                ProductId = GetNextProductId(),
                Brand = "Waterproof",
                Model = "W5",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                Thickness = 3.5,
                PricePerDay = 100,
                ImageFileName = "divingsuitW5.jpg"
            },
            new DivingSuit
            {
                ProductId = GetNextProductId(),
                Brand = "Fourth Element",
                Model = "Proteus",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                Thickness = 5,
                PricePerDay = 120,
                ImageFileName = "divingsuitproteus.jpg"
            },
            new DivingSuit
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "Exodry 4.0",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Tørdragt",
                Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                PricePerDay = 300,
                ImageFileName = "divingsuitexodry.webp"
            },
            new DivingSuit
            {
                ProductId = GetNextProductId(),
                Brand = "Waterproof",
                Model = "D7 Evo",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Tørdragt",
                Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                PricePerDay = 320,
                ImageFileName = "divingsuitd7evo.jpg"
            },
            new DivingSuit
            {
                ProductId = GetNextProductId(),
                Brand = "Santi",
                Model = "E.Lite Plus",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Tørdragt",
                Gender = new List<DivingSuitGender> { DivingSuitGender.Herre, DivingSuitGender.Dame },
                PricePerDay = 350,
                ImageFileName = "divingsuiteliteplus.jpg"
            }
            );
            modelBuilder.Entity<Fin>().HasData(
            new Fin
                {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                    Model = "Jet Fin",
                    Sizes = new List<FinSize> { FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                    PricePerDay = 50,
                    ImageFileName = "finjetfn.jpg"
                },
            new Fin
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "GO Travel",
                Sizes = new List<FinSize> { FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50,
                ImageFileName = "fingofin.jpg"
            },
            new Fin
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "Seawing Supernova",
                Sizes = new List<FinSize> { FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 60,
                ImageFileName = "finjetfn.jpg"
            },
            new Fin
            {
                ProductId = GetNextProductId(),
                Brand = "Seac",
                Model = "Propulsion",
                Sizes = new List<FinSize> { FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50,
                ImageFileName = "fingofin.jpg"
            },
            new Fin
            {
                ProductId = GetNextProductId(),
                Brand = "Seac",
                Model = "ALA",
                Sizes = new List<FinSize> { FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50,
                ImageFileName = "fingofin.jpg"
            },
            new Fin
            {
                ProductId = GetNextProductId(),
                Brand = "Fourth Element",
                Model = "Tech",
                Sizes = new List<FinSize> { FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 75,
                ImageFileName = "finjetfn.jpg"
            },
            new Fin
            {
                ProductId = GetNextProductId(),
                Brand = "Fourth Element",
                Model = "Rec Fin",
                Sizes = new List<FinSize> { FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 80,
                ImageFileName = "finjetfn.jpg"
            }
            );
            modelBuilder.Entity<Mask_Snorkel>().HasData(
                 new Mask_Snorkel
                 {
                     ProductId = GetNextProductId(),
                     Brand = "Scubapro",
                     Model = "Ghost",
                     PricePerDay = 50,
                     ImageFileName = "Maske&Snorkel.png"
                 },
            new Mask_Snorkel
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "D-Mask",
                PricePerDay = 60,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "Spectra Mini",
                PricePerDay = 50,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Model = "Crystal VU",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel
            {
                ProductId = GetNextProductId(),
                Brand = "Fourth Element",
                Model = "Scout Kontrast",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel
            {
                ProductId = GetNextProductId(),
                Brand = "Fourth Element",
                Model = "Scout Enhance",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel
            {
                ProductId = GetNextProductId(),
                Brand = "Tusa",
                Model = "Element",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            }
            );
            modelBuilder.Entity<RegulatorSet>().HasData(
                 new RegulatorSet
                 {
                     ProductId = GetNextProductId(),
                     Brand = "Scubapro",
                     StepOne = "MK25EVO",
                     StepTwo = "S600",
                     Octopus = "R105",
                     PricePerDay = 125,
                     ImageFileName = "Regulator-Set.png"
                 },
            new RegulatorSet
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                StepOne = "MK17EVO",
                StepTwo = "C370",
                Octopus = "R095",
                PricePerDay = 100,
                ImageFileName = "Regulator-Set.png"
            },
            new RegulatorSet
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                StepOne = "MK25EVO BT",
                StepTwo = "A700 Carbon BT",
                Octopus = "S270",
                PricePerDay = 150,
                ImageFileName = "Regulator-Set.png"
            }
            );
            modelBuilder.Entity<Tank>().HasData(
                new Tank
                {
                    ProductId = GetNextProductId(),
                    Brand = "Scubapro",
                    Volume = 5,
                    PricePerDay = 150,
                    ImageFileName = ""
                },

            new Tank
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Volume = 10,
                PricePerDay = 160,
                ImageFileName = ""
            },

            new Tank
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Volume = 12,
                PricePerDay = 170,
                ImageFileName = ""
            },

            new Tank
            {
                ProductId = GetNextProductId(),
                Brand = "Scubapro",
                Volume = 15,
                PricePerDay = 180,
                ImageFileName = ""
            }
            );



        }
        // Constructor med DbContextOptions - kalder base constructor
        public TrueDiveDeepContext(DbContextOptions<TrueDiveDeepContext> options)
            : base(options)
        {

        }
    }
}

