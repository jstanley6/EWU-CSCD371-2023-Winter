using System;

namespace CanHazFunny;

public class Jester
{

    public IJokeService JokeService { get; }
    public IOutputJoke OutputJoke { get; }
    public string? Joke { get; set; }
    public Jester(IJokeService jokeService, IOutputJoke outputJoke)
    {
        JokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
        OutputJoke = outputJoke ?? throw new ArgumentNullException(nameof(outputJoke));
    }
  
    public void TellJoke()
    {
        do
        {
            Joke = JokeService.GetJoke();
        } while (Joke.Contains("Chuck Norris", StringComparison.OrdinalIgnoreCase));

        OutputJoke.TellJoke(Joke);
    }
}
