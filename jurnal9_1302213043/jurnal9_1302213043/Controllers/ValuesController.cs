using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jurnal9_1302213043.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : Controller
    {
        public static List<Mahasiswa> mhs = new List<Mahasiswa>()
        {
            new Mahasiswa {Name = "Jaatsiyah Maulidina Astrianto", Nim = "1302213043",Course = new List<string>{"PBO","KPL","BASDAT","SQA","JARKOM","TPLM","UX","PROTING2" }, Year = 2021 },
            new Mahasiswa {Name = "Hilma Fariz Hirzi", Nim = "1302213092",Course = new List<string>{"PBO","KPL","BASDAT","SQA","JARKOM","TPLM","UX","PROTING2" }, Year = 2021 },
            new Mahasiswa {Name = "Putri Auliya Rahmah", Nim = "1302210033",Course = new List<string>{"PBO","KPL","BASDAT","SQA","JARKOM","TPLM","UX","PROTING2" }, Year = 2021 }
        };

        // GET/api/Mahasiswa : Mengembalikan output berupa list/array dari semua objek Mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        // GET/api/Mahasiswa/{id} : Mengembalikan output berupa objek mahasiswa untuk index "id"
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        // POST api/Mahasiswa : Menambahkan objek Mahasiswa baru
        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa newMahasiswa)
        {
            mhs.Add(newMahasiswa);
            return Ok();
        }

        // DELETE api/Mahasiswa/{id} : menghapus objek mahasiswa pada index "id"
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(id);
            return Ok();
        }
    }
}
