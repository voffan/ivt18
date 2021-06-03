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

        static public string getPictureById(int PicId, Context C)
        {
            return C.Pictures.Where(c => c.PictureId == PicId)
                .Select(c => c.Name).FirstOrDefault();
        }

        static public string getArtistById(int ArtId, Context C)
        {
            return C.Artists.Where(c => c.ArtistId == ArtId)
                .Select(c => c.FullName).FirstOrDefault();
        }

        static public string getGenreById(int GenId, Context C)
        {
            return C.Genres.Where(c => c.GenreId == GenId)
                .Select(c => c.Name).FirstOrDefault();
        }

        static public string getDepartmentById(int DepId, Context C)
        {
            return C.Departments.Where(c => c.DepartmentId == DepId)
                .Select(c => c.Name).FirstOrDefault();
        }

        static public string getGalleryById(int? GalId, Context C)
        {
            return C.Galleries.Where(c => c.GalleryId == GalId)
                .Select(c => c.Name).FirstOrDefault();
        }

        static public string getJournalById(int JourId, Context C)
        {
            return C.Departments.Where(c => c.DepartmentId == JourId)
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

        public static void UpdatePicture(Context c, int pictureId, string name, Single price, int year, string artistName, string genreName, string departmentName, string galleryName)
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

        public static void sendToResto(Context c, int pictureId1, int employeeId1)
        {
            Picture p = c.Pictures
            .Where(o => o.PictureId == pictureId1)
            .FirstOrDefault();
            if (p.DepartmentId == 1)
            {
                Journal j = new Journal();
                j.Date = DateTime.Today;
                j.DepartmentFromId = 1;
                j.DepartmentToId = 2;
                j.PictureId = pictureId1;
                j.EmployeeId = employeeId1;
                c.Journals.Add(j);
                p.DepartmentId = 2;
                c.SaveChanges();
            }
        }

        public static void deleteFromResto(Context c, int journalId2)
        {
            Journal hh = c.Journals
            .Where(l => l.JournalId == journalId2)
            .FirstOrDefault();

            int pictureId2 = hh.PictureId;

            Picture p = c.Pictures
            .Where(o => o.PictureId == pictureId2)
            .FirstOrDefault();
            p.DepartmentId = 1;

            c.Journals.Remove(hh);
            c.SaveChanges();
        }
    }
}
