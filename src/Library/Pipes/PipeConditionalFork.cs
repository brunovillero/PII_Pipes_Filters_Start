using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;
using CompAndDel.Filters;

namespace CompAndDel.Pipes
{
    public class PipeConditionalFork : IPipe
    {
        protected FilterConditional filtro;
        IPipe next2Pipe;
        IPipe nextPipe;
        
        public PipeConditionalFork(FilterConditional filtro,IPipe nextPipe, IPipe next2Pipe) 
        {
            this.filtro=filtro;
            this.next2Pipe = next2Pipe;
            this.nextPipe = nextPipe;           
        }
        
  
        public IPicture Send(IPicture picture)
        {
            if (this.filtro.Filter(picture))
            {
                return nextPipe.Send(picture);
            }
            else
            {
                return next2Pipe.Send(picture);
            }
        }
    }
}