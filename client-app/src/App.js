import { AllRoutes } from "./routes/AllRoutes";
import { Header, Footer } from "./components";
import { useState } from 'react';
function App() {

  const [activeLink, setActiveLink] = useState("home");

  return (
    <>
      <Header activeLink={activeLink} setActiveLink={setActiveLink} />
      <AllRoutes />
      <Footer />
    </>
  );
}

export default App;
