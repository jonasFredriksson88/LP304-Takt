﻿namespace rest_api.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AreaId { get; set; }
        public Area area { get; set; }
    }
}
