using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Extensions;

public class PaginatedList<T> : List<T>
{
    public int PageIndex { get; set; }
    public int TotalPages { get; set; }

    public PaginatedList(List<T> source, int pageIndex, int pageSize, int totalCount)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
        this.AddRange(source);
    }

    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;

    // Converts to a List<int> for iterating using foreach in Index.cshml
    public List<int> GetPageNumbers(int totalPages)
    {
        var pageNumbers = new List<int>(totalPages);

        for (var i = 1; i <= totalPages; i++)
        {
            pageNumbers.Add(i);
        }

        return pageNumbers;
    }
}
