using System;
using System.Xml.Linq;

namespace State
{
    public interface State
    {
        void AceitarDocumento();
        void RejeitarDocumento();
        void AvaliarDocumento();
        void Print();
    }
}
