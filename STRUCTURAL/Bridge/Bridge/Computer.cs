using System.Collections.Generic;

namespace Bridge {
    // Computer
    public class Computer {
        public List<ModelBase> Models = new List<ModelBase>();  // Components
        public IViewer Viewer = new OldViewer();                // Viewer

        public Computer(params ModelBase[] Models) {
            foreach(ModelBase model in Models)
                this.Models.Add(model);
        }

        public void ShowInfo() => Viewer.Show(this);
    }
}
