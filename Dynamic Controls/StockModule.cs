using System;

namespace Dynamic_Controls
{
    public class StockModule : IModuleInterface
    {
        public StockModule(ModuleControlSurface module)
        {
            controlSurface = module;
        }

        public void SetMaxDeflect(float val)
        {
            controlSurface.authorityLimiter = val;
        }

        public float GetDefaultMaxDeflect()
        {
            return 100;
        }

        private ModuleControlSurface controlSurface;
    }
}
