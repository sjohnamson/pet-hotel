using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType
    {
        Shepherd,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }

    public enum PetColorType
    {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted
    }
    public class Pet
    {

        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public PetBreedType breed { get; set; }

        [Required]
        public PetColorType color { get; set; }

        public DateTime checkedInAt { get; set; }

        [Required]
        public int petOwnerid { get; set; }

        [ForeignKey("petOwnerid")]
        public PetOwner petOwner { get; set; }


    }
}
