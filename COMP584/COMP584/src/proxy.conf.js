const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
    ],
    target: "https://localhost:50433",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
