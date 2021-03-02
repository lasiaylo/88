namespace Util {
    public class Toggle {
        public static implicit operator bool(Toggle toggle) => toggle.Status;

        public static implicit operator int(Toggle toggle) => toggle.Status ? 1 : 0;

        public Toggle(bool status = false) {
            Status = status;
        }

        public bool Status { get; private set; }

        public bool Flip() {
            Status = !Status;
            return Status;
        }
    }
}