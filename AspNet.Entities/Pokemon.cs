﻿namespace AspNet.Entities;
public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }

    public List<Ability> Abilities { get; set; }
}

