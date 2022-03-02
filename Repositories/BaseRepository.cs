using System.Data;
using Dotsql.Settings;
using Npgsql;

namespace Dotsql.Repositories;
public class ;
public main;

public class BaseRepository
{
    private readonly IConfiguration _configuration;
    public BaseRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public NpgsqlConnection NewConnection => new NpgsqlConnection(_configuration
        .GetSection(nameof(PostgresSettings)).Get<PostgresSettings>().ConnectionString);
}
