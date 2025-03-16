<<<<<<< HEAD
using System;

namespace Domain;

public class Activity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public required string Title { get; set; }

    public DateTime Date { get; set; }

    public required string Description { get; set; }

    public required string Category { get; set; }

    public bool IsCancelled { get; set; }

//location properties
    public required string City { get; set; }

    public required string Venue { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }


}
=======
namespace Domain
{
    //Domain entity
    public class Activity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string City { get; set; }

        public string Venue { get; set; }
    }
}
>>>>>>> 6ce334a6797b4f2ef72097465f399b338f7f0e59
