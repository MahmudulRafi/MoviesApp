import React from 'react';
import logo from './logo.svg';
import './App.css';
import IndividualMovie from './components/movies/IndividualMovie';
import { movieDTO } from './components/movies/movie.modal';

function App() {

  const testMovie: movieDTO = {
    id: 1,
    title: "Spider Man",
    poster: "https://img1.hotstarext.com/image/upload/f_auto,t_hcdl/sources/r1/cms/prod/2356/1282356-h-a6b1c484c811"
  }

  return (
    <>
      <IndividualMovie {...testMovie} />
    </>
  );
}

export default App;
