﻿using System.Web;

namespace Nina
{
    public class FileResult : BaseResult
    {
        private readonly string _path;

        public FileResult(string path)
        {
            _path = path;
        }

        public override void Execute(HttpContext context)
        {
            base.Execute(context);

            context.Response.TransmitFile(_path);
        }
    }
}