open System

// Define units of measure.

/// <summary>
/// The metre unit.
/// </summary>
[<Measure>] type m

/// <summary>
/// The second unit.
/// </summary>
[<Measure>] type s

/// <summary>
/// The kilogram unit.
/// </summary>
[<Measure>] type kg

/// <summary>
/// The Joule unit.
/// </summary>
/// <remarks>J = kgm^2s^-2</remarks>
[<Measure>] type J = kg * (m * m) / (s * s)

// Define physical constants.

/// <summary>
/// The speed of light, 2.998 ms^-1.
/// </summary>
let speedOfLight = 2.998<m/s> * (10. ** 8.)

/// <summary>
/// Planck's Constant, 6.626 Js.
/// </summary>
let plancksConstant = 6.626<J * s> * (10. ** -34.)

// Define calculation functions.

/// <summary>
/// Calculates the energy in J from the mass in kg.
/// </summary>
/// <param name="mass">The mass in kg</param>
/// <remarks>Formula: E = mc^2.</remarks>
let energyFromMass (mass:float<kg>) = mass * (speedOfLight * speedOfLight)

/// <summary>
/// Calculates the frequency in s^-1 from the energy in J.
/// </summary>
/// <param name="energy">The energy in J.</param>
/// <remarks>Formula: E = h[nu] => [nu] = E/h.</remarks>
let frequencyFromEnergy (energy:float<J>) = energy / plancksConstant

/// <summary>
/// Calculates the wavelength in m from the frequency in s^-1.
/// </summary>
/// <param name="frequency">The frequency in s^-1.</param>
/// <remarks>Formula: c = [lambda][nu] => [lambda] = c/[nu].</remarks>
let wavelengthFromFrequency (frequency:float<1/s>) = speedOfLight / frequency

/// <summary>
/// Calculates the wavelength in m from the mass in kg as a composed function.
/// </summary>
let wavelengthFromMass = energyFromMass >> frequencyFromEnergy >> wavelengthFromFrequency

[<EntryPoint>]
let main argv = 
    let photonMass = 4.420<kg> * (10. ** -36.)
    let photonEnergy = energyFromMass photonMass
    let photonFrequency = frequencyFromEnergy photonEnergy
    let photonWavelength = wavelengthFromFrequency photonFrequency

    let photonWavelengthInNm = photonWavelength * (10. ** 9.)
    
    printfn "Photon Wavelength: %A nm" photonWavelengthInNm
    Console.ReadKey |> ignore
    0
