string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft"};

// Consulta completa:
IEnumerable<string> filteredGames1 = from game in games
                                        where game.Contains('a')
                                        select game;

// Consulta simplificada (usando tipos implícitos):
var filteredGames2 = from game in games
                  where game.Contains('a')
                  select game;
