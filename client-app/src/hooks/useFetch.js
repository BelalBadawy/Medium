import { useEffect, useState } from "react";
import axios from "axios";

function useFetch(url) {
    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(null);

    useEffect(() => {
        const controller = new AbortController();
        const fetchData = async (url) => {
            setLoading(true);
            await axios
                .get(url)
                .then((response) => {
                    console.log(response.data);
                    setData(response.data);
                })
                .catch((err) => {
                    setError(err);
                })
                .finally(() => {
                    setLoading(false);
                });
        };

        if (url) {
            fetchData(url);
        }

        return () => {
            controller.abort();
        };
    }, [url]);

    return { data, loading, error };
}

export default useFetch;