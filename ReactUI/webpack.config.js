const path = require('path');

module.exports = {
  mode: 'development',
  entry: './src/index.js',
  output: {
    path: path.resolve(__dirname, '../CorefloodApp/wwwroot/scripts'),
    filename: 'app.bundle.js',
    library: "ChartLibrary"
  },
  module: {
    rules:[
        {
            test:/\.(js|jsx)$/,
            exclude: /node_modules/,
            use:{
                loader: "babel-loader"
            }
        },
        {
          test: /\.css$/i,
          use: ["style-loader", "css-loader"],
        }
    ]
  }
};