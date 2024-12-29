using System;

namespace API.Helpers;

public class PaginationHeader(int currrentPage, int itemsPerPage, int totalItems, int totalPages)
{
    public int CurrrentPage {get; set;} = currrentPage;
    public int ItemsPerPage {get; set;} = itemsPerPage;
    public int TotalItems {get; set;} = totalItems;
    public int TotalPages {get; set;} = totalPages;
}
