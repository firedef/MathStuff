namespace MathStuff; 

/// <summary>fixed point value between -1 and 1<br /><b>step: ~0.000031 (1/32768)</b></summary>
public struct fix16 {
	public static readonly fix16 zero = new(0);
	public static readonly fix16 max = new(short.MaxValue);
	public static readonly fix16 min = new(short.MinValue);

	private const float _range = 1;

	public const int i16Max = 32767;
	public const float step = _range / 32767;
	public const float stepPow = step * step;

	public readonly short raw;

	public int sign => (raw >> 15) & 0b1;

	public fix16(short raw) => this.raw = raw;
	public fix16(int raw) => this.raw = (short)math.clampFast_i16(raw, -i16Max, i16Max);
	public fix16(float raw) : this() => floatValue = raw;

	public float floatValue {
		get => raw * step;
		init => raw = (short)math.clampFast_i16((int)(value * i16Max), -i16Max, i16Max);
	}

	public override string ToString() => floatValue.ToString(@"0.0000");

	public static implicit operator float(fix16 v) => v.floatValue;
	public static implicit operator fix16(float v) => new(v);

	public static fix16 operator +(fix16 a, fix16 b) => new(a.raw + b.raw);
	public static fix16 operator -(fix16 a, fix16 b) => new(a.raw - b.raw);
	public static fix16 operator -(fix16 a) => new(-a.raw);

	public static fix16 operator ++(fix16 a) => new(a.raw + 1);
	public static fix16 operator --(fix16 a) => new(a.raw - 1);

	public static fix16 operator *(fix16 a, fix16 b) => new(a.raw * b.raw * stepPow);
	public static fix16 operator /(fix16 a, fix16 b) => new((float) a.raw / b.raw);

	public static fix16 operator +(fix16 a, float b) => new(a.raw * step + b);
	public static fix16 operator -(fix16 a, float b) => new(a.raw * step - b);
	public static fix16 operator *(fix16 a, float b) => new(a.raw * b * step);
	public static fix16 operator /(fix16 a, float b) => new(a.raw / b * step);

	public static bool operator ==(fix16 a, fix16 b) => a.raw == b.raw;
	public static bool operator !=(fix16 a, fix16 b) => a.raw != b.raw;
	public static bool operator >(fix16 a, fix16 b) => a.raw > b.raw;
	public static bool operator <(fix16 a, fix16 b) => a.raw < b.raw;
	public static bool operator >=(fix16 a, fix16 b) => a.raw >= b.raw;
	public static bool operator <=(fix16 a, fix16 b) => a.raw <= b.raw;

	public static fix16 operator ~(fix16 a) => new(~a.raw);

	public fix16 abs => new(raw < 0 ? -raw : raw);

	public float differenceTo(fix16 other) => math.abs(raw - other.raw) * step;

	public override bool Equals(object? obj) => obj is fix16 other && Equals(other);
	public override int GetHashCode() => raw.GetHashCode();
	public bool Equals(fix16 other) => raw == other.raw;
}