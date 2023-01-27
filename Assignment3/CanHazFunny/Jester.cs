using System;

namespace CanHazFunny;

public class Jester
{
    public JokeService _jokeService { get; set; }

    public OutputJoke _outputJoke  { get; set; }

    public Jester(JokeService _jokeService, OutputJoke _outputJoke)
    {
        this._jokeService = _jokeService ?? throw new ArgumentNullException(nameof(_jokeService));
        this._outputJoke = _outputJoke ?? throw new ArgumentNullException(nameof(_outputJoke));
    }
  
    public string TellJoke()
    {
        string joke;
        do
        {
            joke = _jokeService.GetJoke();
        } while (joke.Contains("Chuck Norris"));

        return joke;
    }

    public void Print(string output)
    {
        _outputJoke.Print(output);
    }
}
