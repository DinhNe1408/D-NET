using System.Diagnostics;
using API._Services.Interfaces;
using API.Models;
using SDCores;

namespace API._Services.Services
{
    public class S_Demo : I_Demo
    {
        public async Task<OperationResult> Demo()
        {
            return new OperationResult(true);
        }
    }
}