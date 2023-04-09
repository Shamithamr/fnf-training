using System;

namespace Csharpbasics
{
    public class Banks
    {
        public string Name { get; set; }
        public string Adhar { get; set; }
        public string Pan { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }

        public Banks(string name, string adhar, string pan, string email, byte[] photo)
        {
            Name = name;
            Adhar = adhar;
            Pan = pan;
            Email = email;
            Photo = photo;
        }
    }

    public class BanksBuilder
    {
        private string _name;
        private string _adhar;
        private string _pan;
        private string _email;
        private byte[] _photo;

        public BanksBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public BanksBuilder WithAdhar(string adhar)
        {
            _adhar = adhar;
            return this;
        }

        public BanksBuilder WithPan(string pan)
        {
            _pan = pan;
            return this;
        }

        public BanksBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }

        public BanksBuilder WithPhoto(byte[] photo)
        {
            _photo = photo;
            return this;
        }

        public Banks Build()
        {
            return new Banks(_name, _adhar, _pan, _email, _photo);
        }
    }

    internal class bankbuilder
    {
        private static void Main(string[] args)
        {
            var photoData = new byte[] { 0x12, 0x34, 0x56, 0x78 };
            var myObject = new BanksBuilder()
                .WithName("MyBank")
                .WithAdhar("123456789012")
                .WithPan("ABCDE1234F")
                .WithEmail("bank@example.com")
                .WithPhoto(photoData)
                .Build();

            Console.WriteLine("Name: " + myObject.Name);
            Console.WriteLine("Adhar: " + myObject.Adhar);
            Console.WriteLine("PAN: " + myObject.Pan);
            Console.WriteLine("Email: " + myObject.Email);
            Console.WriteLine("Photo size: " + myObject.Photo.Length);
        }
    }
}
