using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using WebAPICore.Models;
using WebAPICore.Utils;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DAL objDal = new DAL();
            string sql = $"SELECT * FROM CLIENTE WHERE ID = {id}";
            DataTable dados = objDal.RetornarDataTable(sql);

            return dados.Rows[0]["Nome"].ToString();
        }

        // POST api/values
        [HttpPost]
        [Route("postCliente")]
        public ReturnAllServices PostCliente([FromBody]Cliente cliente)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                cliente.RegistrarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao registrar cliente: " + ex.Message;
            }
            return retorno;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
