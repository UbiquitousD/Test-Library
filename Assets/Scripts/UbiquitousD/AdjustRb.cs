using UnityEngine;

namespace UbiquitousD
{
    public static class AdjustRb
    {
        public static void OverwriteVelocityLeft2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(-addPower, rb.velocity.y);
        public static void OverwriteVelocityRight2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(addPower, rb.velocity.y);
        public static void OverwriteVelocityUp2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(rb.velocity.x, addPower);
        public static void OverwriteVelocityDown2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(rb.velocity.x, -addPower);
        public static void OverwriteVelocityUpperLeft2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(-addPower, addPower);
        public static void OverwriteVelocityUpperRight2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(addPower, addPower);
        public static void OverwriteVelocityLowerLeft2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(-addPower, -addPower);
        public static void OverwriteVelocityLowerRight2D(Rigidbody2D rb, float addPower) => rb.velocity = new Vector2(addPower, -addPower);
    }
}