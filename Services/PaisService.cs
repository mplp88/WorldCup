using WorldCup.DAL;
using WorldCup.Models;

namespace WorldCup.Services;

public class PaisService
{
    WorldCupContext _context;

    public PaisService(WorldCupContext context)
    {
        _context = context;
    }

    public Pais Get(int id)
    {
        return _context.Paises.Where(p => p.Id == id).First();
    }

    public IEnumerable<Pais> GetAll()
    {
        return _context.Paises.ToList();
    }

    public bool Add(Pais pais)
    {
        try
        {
            var p = _context.Paises.Add(pais);
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool Update(int id, Pais pais)
    {
        try
        {
            if (_context.Paises.Any(p => p.Id == id))
            {
                _context.Paises.Update(pais);
                _context.SaveChanges();
            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool Delete(int id)
    {
        bool ret = false;

        try
        {
            if (_context.Paises.Any(p => p.Id == id))
            {
                _context.Paises.Remove(_context.Paises.Where(p => p.Id == id).First());
                _context.SaveChanges();
            }

            ret = true;
        }
        catch (Exception)
        {
            ret = false;
        }

        return ret;
    }

    public int Count()
    {
        return _context.Paises.Count();
    }
}