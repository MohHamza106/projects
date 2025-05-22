using Microsoft.AspNetCore.Mvc;

namespace project1_structure_mvc.controllrs
{
    public class MoviesController:Controller
    {
        //if user used method is not action but method   
        [NonAction]
        public void delete()
        {

        }
        public string Index()
        {
            return "hello world  from index";
        }
        //[HttpGet]
        //public string GetMovie(int? id, string? name)
        //{
        //    return $" movie with id :{id} and  name :{name}";
        //}
        //if control result 
        [HttpGet]
        public IActionResult GetMovie(int? id, string? name)
        {
            //ContentResult result = new ContentResult();
            //result.Content= $" movie with id :{id} and <br/> name :{name}";
            //result.ContentType = "text/html";
            //return result;
            //other way
            //return Content($" movie with id :{id} and <br/> name :{name}","text/html");
            //other way
            if (id == 0)
                return BadRequest();
            else if(id > 10)
                return NotFound();
            else
                return Content($" movie with id :{id} and <br/> name :{name}","text/html");



        }
    }
}
