using System.Linq;
using System.Linq.Dynamic.Core;
using GhabzeTo.Application.Core.DTOs.SPF;

namespace GhabzeTo.Application.Core.Extensions
{
    public static class IQueryableExtensions
    {
        /// <summary>
        /// It's do sorting, paging and filtering
        /// </summary>
        public static IQueryable<T> SPF<T>(this IQueryable<T> query,
            SPFInputDto model, out long totalRecord)
        {
            // اعمال فیلتر
            if (!string.IsNullOrWhiteSpace(model.SearchTerm))
            {
                var searchTerm = model.SearchTerm.Trim().ToLower();
                var searchQ = string.Empty;

                var objectProperties = typeof(T).GetProperties();
                var objPropertiesLength = objectProperties.Length;

                var objPropertiesName = new string[objPropertiesLength];

                // بیرون کشیدن نام پراپرتی ها
                for (var i = 0; i < objPropertiesLength; i++)
                {
                    objPropertiesName[i] = objectProperties[i].Name;
                }

                for (var i = 0; i < objPropertiesLength; i++)
                {
                    // بررسی نوع داده
                    if (objectProperties[i].IsStringType())
                    {
                        searchQ +=
                            $"({objPropertiesName[i]} != null && " +
                            $"{objPropertiesName[i]}.ToLower().Contains" +
                            $"(\"{searchTerm}\")) || ";
                    }
                    else
                    {
                        // اگر نوع عددی نبود برو به ابتدای حلقه
                        if (!objectProperties[i].IsNumericType()) continue;

                        // آیا نوع اعشاری هست؟
                        if (objectProperties[i].IsDecimalType())
                        {
                            // اگر سرچ قابل تبدیل به اعشاری بود، آن را تبدیل کن
                            if (decimal.TryParse(searchTerm,
                                out decimal parsedSearchTerm))
                            {
                                searchQ +=
                                    $"{objPropertiesName[i]} == " +
                                    $"{parsedSearchTerm} || ";
                            }
                        }
                        else
                        {
                            // اگر سرچ قابل تبدیل به عددی بود، آن را تبدیل کن
                            if (long.TryParse(searchTerm,
                                out var parsedSearchTerm))
                            {
                                searchQ +=
                                    $"{objPropertiesName[i]} == " +
                                    $"{parsedSearchTerm} || ";
                            }
                        }
                    }
                }

                // حذف 4 کاراکتر اضافی انتهای سرچ تولید شده
                searchQ = searchQ.Remove(searchQ.Length - 4);

                // اعمال سرچ
                query = query.Where(searchQ);
            }

            // اعمال سورت روی اطلاعات
            if (!string.IsNullOrWhiteSpace(model.SortColumnName))
            {
                var sortTypeStr =
                    model.SortType == SortType.Asc ? "ASC" : "DESC";
                query = query?.OrderBy($"{model.SortColumnName} {sortTypeStr}");
            }

            totalRecord = query.LongCount();

            // صفحه بندی
            query = query.ToList()
                .Skip((model.PageNumber - 1) * model.PageSize)
                .Take(model.PageSize)
                .AsQueryable();

            return query;
        }
    }
}
