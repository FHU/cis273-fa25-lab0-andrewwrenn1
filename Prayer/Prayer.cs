﻿namespace Prayer;

public class Prayer
{
    public string Title { get; set; } = "";

    public string Subtitle { get; set; } = "";

    public string Body { get; set; } = "";


    public List<ScriptureReference> ScriptureReferences { get; set; } = new List<ScriptureReference>();

    public Author Author { get; set; } = new Author();

    public List<Tag> Tags { get; set; } = new List<Tag>();

    public Uri? ImageURL { get; set; }

    public DateTime CreatedAt { get; set; } = new();

    public DateTime UpdatedAt { get; set; } = new();

    public override string ToString()
    {
        return $"{Title}:{Subtitle} - {Author}";
    }
    
}

