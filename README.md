Caso 1: Viento Direccional con Turbulencia (WildForce)

Para obtener la fuerza del viento se implementó la formula F = Fbase + Fvariable(t), siendo F la fuerza total del viento (WindForceRealist), Fbase la fuerza del viento y Fvariable la turbulencia y la (t) significa "en función del tiempo", esta esta reflejada con Mathf.PerlinNoise(Time.time...)

F = Fbase + Fvariable(t)
WindForceRealist = (windDirection * strength) + (windDirection * realSensation)
WindForceRealist = WildForceBase + (windDirection * realSensation)

Los parámetros utilizados fueron:
* ImpactRange determina el radio de la zona de viento. Si la bandera está lejos del objeto, deja de moverse.
* GlobalImpact hace que el viento sople en todo el mundo de la simulación, cuando se activa, ignora la distancia y el rango.
* windDirection define hacia qué lado sopla el viento (eje X, Y o Z).
* strenght controla la potencia base del viento, haciendo que la bandera se estire más si el valor aumenta.
* turbulenceIntensity indicará la intensidad de las réfagas de viento (turbulencias).
* turbulenceFrequency indica que tan frecuentes serán las turbulencias.
