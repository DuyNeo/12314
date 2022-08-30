using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


public interface IMonAnSvc
{
    List<MonAn> GetMonAnAll();
    MonAn GetMonAn(int id);
    Task<int> AddMonAn(MonAn monAn);
    Task<int> EditMonAn(int id, MonAn monAn);
}
public class MonAnSvc : IMonAnSvc

{

    protected DataContext _context;
    public MonAnSvc(DataContext context)
    {
        _context = context;
    }

    public async Task<int> AddMonAn(MonAn monAn)
    {
        int ret = 0;
        try
        {
            await _context.AddAsync(monAn);
            await _context.SaveChangesAsync();
            ret = monAn.Id;
        }
        catch
        {
            ret = 0;
        }
        return ret;
    }

    public async Task<int> EditMonAn(int id, MonAn monAn)
    {
        int ret = 0;
        try
        {
            var model = _context.Update(monAn);
            model.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            ret = monAn.Id;
        }
        catch
        {
            ret = 0;
        }
        return ret;
    }

    public MonAn GetMonAn(int id)
    {
        return _context.MonAns.Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
    }

    public List<MonAn> GetMonAnAll()
    {
        return _context.MonAns.Include(x => x.Photos).ToList();
    }
}

