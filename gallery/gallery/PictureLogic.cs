using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery
{
    class PictureLogic
    {
        static public int getArtistId(string s, Context C)
        {
            return C.Artists.Where(c => c.FullName == s)
                .Select(c => c.ArtistId).FirstOrDefault();
        }

        static public int getGenreId(string s, Context C)
        {
            return C.Genres.Where(c => c.Name == s)
                .Select(c => c.GenreId).FirstOrDefault();
        }

        static public int getPlaceId(string s, Context C)
        {
            return C.Departments.Where(c => c.Name == s)
                .Select(c => c.DepartmentId).FirstOrDefault();
        }

        static public int getGalleryId(string s, Context C)
        {
            return C.Galleries.Where(c => c.Name == s)
                .Select(c => c.GalleryId).FirstOrDefault();
        }

<<<<<<< HEAD
        static public string getPictureById(int PicId, Context C)
        {
            return C.Pictures.Where(c => c.PictureId == PicId)
                .Select(c => c.Name).FirstOrDefault();
        }

        static public string getJournalById(int JourId, Context C)
        {
            return C.Places.Where(c => c.PlaceId == JourId)
                .Select(c => c.Name).FirstOrDefault();
        }

        static public string getEmployeeById(int empId, Context C)
        {
            return C.Employees.Where(c => c.EmployeeId == empId)
                .Select(c => c.FullName).FirstOrDefault();
        }

        static public string getExpoById(int empId, Context C)
        {
            return C.Expos.Where(c => c.ExpoId == empId)
                .Select(c => c.Name).FirstOrDefault();
        }

        public static void AddPicture(Context c, string name, Single price, int year, string artistName, string genreName, string departmentName, string galleryName)
        {
            Picture p = new Picture();
            p.Name = name;
            p.Price = price;
            p.Year = year;
            int artistId = getArtistId(artistName, c);
            int genreId = getGenreId(genreName, c);
            int departmentId = getPlaceId(departmentName, c);
            int galleryId = getGalleryId(galleryName, c);
            p.ArtistId = artistId;
            p.GenreId = genreId;
            p.DepartmentId = departmentId;
            p.GalleryId = galleryId;
            c.Pictures.Add(p);
            c.SaveChanges();
        }

        public static void DeletePicture(Context c, int id)
        {
            Picture p = c.Pictures
            .Where(o => o.PictureId == id)
            .FirstOrDefault();

            c.Pictures.Remove(p);
            c.SaveChanges();
        }

        public static void UpdatePicture(Context c, string name, Single price, int year, string artistName, string genreName, string departmentName, string galleryName)
        {
            int artistId = getArtistId(artistName, c);
            int genreId = getGenreId(genreName, c);
            int departmentId = getPlaceId(departmentName, c);
            int galleryId = getGalleryId(galleryName, c);

            Picture p = c.Pictures
            .Where(o => o.PictureId == pictureId)
            .FirstOrDefault();

            if (p != null)
            {
                p.Name = name;
                p.Price = price;
                p.Year = year;
                p.ArtistId = artistId;
                p.GenreId = genreId;
                p.DepartmentId = departmentId;
                p.GalleryId = galleryId;
                c.SaveChanges();
            }
        }

        public static void sendToResto(Context c, int pictureId1, int employeeId)
        {
            Journal j = new Journal();
            j.Date = DateTime.Today;
            j.PlaceFromId = 1;
            j.PlaceToId = 2;
            j.PictureId = pictureId1;
            j.EmployeeId = employeeId;
            c.Journals.Add(j);
            c.SaveChanges();
        }
    }
}
